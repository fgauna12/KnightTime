#include "msp430g2553.h"

#define ANALOG_PIN      7				// The analog pin 7 is indicating that P1.7 is the analog
#define DELAY_MS		50				// How often the analog pin is read by the code 50 is the lowest stable number
#define IBI_VALUES		20				// The number of values used to create a BPM average
#define DELAY_DISPLAY	250/DELAY_MS	// Used to delay the printf so that it doesnt flood the terminal

/* Functions */
void serial_setup(unsigned out_mask, unsigned in_mask, unsigned duration);
void printf(char *, ...);
void pulse_detect(int Signal);
unsigned int analogRead();
void analogPinSelect(unsigned int pin);
void msDelay(unsigned int msTime);

/* Variables */
volatile int BPM = 0;                   	// used to hold the pulse rate
volatile int IBI = 600;             	// holds the time between beats, the Inter-Beat Interval
volatile int rate[IBI_VALUES];          // used to hold the most recent IBI values
volatile unsigned long sampleCounter = 0;// used to determine pulse timing
volatile unsigned long lastBeatTime = 0;// used to find the inter beat interval
volatile int P = 512;            		// used to find peak in pulse wave
volatile int T = 512;             		// used to find trough in pulse wave
volatile int thresh = 512;           	// used to find instant moment of heart beat
volatile int amp = 100;              	// used to hold amplitude of pulse waveform
volatile int display_counter = 0;		// used for debugging and delays the printf display

void main(void)
{
    int i;

    // Disable watchdog
    WDTCTL = WDTPW + WDTHOLD;

    // Use 8 MHz DCO factory calibration
    DCOCTL = 0;
    BCSCTL1 = CALBC1_8MHZ;
    DCOCTL = CALDCO_8MHZ;

    // Setup the serial port
    // Serial out: P1.1 (BIT1)
    // Serial in:  P1.2 (BIT2)
    // Bit rate:   9600 (CPU freq / bit rate)
    serial_setup(BIT1, BIT2, 8000000 / 9600);


    analogPinSelect( ANALOG_PIN ); // Configures the analog read with the correct pin

    /* Main program loop */
    while(1){
    	msDelay(DELAY_MS);				//Create a mS delay before doing the next read
    	i = analogRead();				//Store the raw analog value in i
    	pulse_detect(i);				//Pass the raw data into the pulse function

    	/* Creates a delay so that the terminal can keep up with the text used for debugging */
    	if(DELAY_DISPLAY < display_counter){
    		printf("\r\nBPM:%i S:%i", BPM, i);

    		display_counter = 0;
    	}
    	++display_counter;
    }
}


unsigned int analogRead(){
  ADC10CTL0 |= ADC10SC;
  while(ADC10CTL1 & ADC10BUSY);
  return ADC10MEM;
}

void analogPinSelect(unsigned int pin){
  if(pin < 8){
    ADC10CTL0 &= ~ENC;
    ADC10CTL1 = pin << 12;
    ADC10CTL0 = ADC10ON + ENC + ADC10SHT_0;
  }
}


 /* Creates a delay in mS */
void msDelay(unsigned int msTime){
	// Internal MCLK is running at 16 Mhz (1/16Mhz = 62.5nS per cycle of code).
	// MCLK = 16000000UL/16000 = 1 ms of real time. Can run a for LOOP that does delays for amount of msTime
	long counter;

	//(1/16Mhz = 62.5nS per cycle of code) __delay_cycles(16000)
	//(1/12Mhz = 83.3nS per cycle of code) __delay_cycles(12000)
	//(1/8Mhz = 125nS per cycle of code) __delay_cycles(8000)
	//(1/1Mhz = 1uS per cycle of code) __delay_cycles(1000)
	for ( counter = 0; counter <= msTime; counter++)
	__delay_cycles(8000);// 1 millisecond delay
}


/* Accepts the analog signal and tries to determine the amount of time between beats */
void pulse_detect(int Signal){
	int j, runningTotal, lastBeat; // Variables only used in this function

	sampleCounter += DELAY_MS;// Increase the beat counter by the amount of delay will be used to determine time between beats
	lastBeat = sampleCounter - lastBeatTime;// used to find how many mS since the last pulse

	// use the now set the P and T values of the pulse wave
	if(Signal > P)
		P = Signal;// P is the peak
	if(Signal < T)
		T = Signal;// T is the trough

	// get amplitude of the pulse wave
	amp = P - T;
	thresh = amp/2 + T;// set thresh at 50% of the amplitude since people say the pulse happens at this point

	// Now the heartbeat needs to be found
	// The signal will surge up from the trough every time there is a pulse
	if( (Signal > thresh) && (lastBeat > (IBI/5)*3) ){
		IBI = sampleCounter - lastBeatTime; // measure time between beats in mS

		// clear the counters now that IBI is set so reset these.
		sampleCounter = 0;					// Clear counter
		lastBeatTime = sampleCounter;		// Clear lastBeatTime

		// now find the average of the stored IBI values
		runningTotal = 0;               	// clear the runningTotal variable

		if(IBI >= 500 && IBI <= 1650){ 		// Limit range to 36 BPM and 120 BPM because that is the range people can be in while sleeping
			for (j=0; j<=(IBI_VALUES - 2); j++) {// shift data in the rate array
				rate[j] = rate[j+1];            // and drop the oldest IBI value
				runningTotal += rate[j];        // add up the oldest IBI values
			}
			rate[IBI_VALUES - 1] = IBI;           // add the latest IBI to the rate array
			runningTotal += rate[IBI_VALUES - 1]; // add the latest IBI to runningTotal
			runningTotal /= IBI_VALUES;           // average the IBI values
			BPM = 60000/runningTotal;          	  // how many beats can fit into a minute? that's BPM!
		}
	}

	/* If a  heart beat has not been detected for 2.5 seconds than reset the variables */
	if (lastBeat > 2500) {	// Restore default values so that it can found again
		sampleCounter = 0;					// Clear counter
		lastBeatTime = sampleCounter;		// Clear lastBeatTime
		amp = 100;
		thresh = 512;
		P = 512;
		T = 512;
	}
}
