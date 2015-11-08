#include "msp430g2553.h"

#define ANALOG_PIN      7
#define DELAY_MS		50
#define IBI_VALUES		15
#define RAW_VALUES		7500/DELAY_MS		//Will store values to find pulses over a time period
#define DELAY_DISPLAY	250/DELAY_MS 		//Determines how many INC's are needed to display
#define BPM_MULT		60000/(RAW_VALUES*DELAY_MS)
#define DIGITAL_VALUES	20


void serial_setup(unsigned out_mask, unsigned in_mask, unsigned duration);
void printf(char *, ...);
void pulse_digital(int Value);
void pulse_detect(int Signal);
unsigned int analogRead();
void analogPinSelect(unsigned int pin);
void msDelay(unsigned int msTime);

// these variables are volatile because they are used during the interrupt service routine!
volatile int BPM;                   	// used to hold the pulse rate
volatile int Pulse = 0;     			// true when pulse wave is high, false when it's low
volatile int pulseCount = 0;
volatile int rawData[RAW_VALUES];         		// used to hold raw data
volatile int P;            			// used to find peak in pulse wave
volatile int T;             		// used to find trough in pulse wave
volatile int thresh;           	// used to find instant moment of heart beat
volatile int amp;
int j;
volatile int digital_IBI[DIGITAL_VALUES], digital_BPM = 0, digital_counter = 0, digital_time = 0, digital_pulse = 0;

int display_counter = 0;

void main(void)
{
    int i;

    // Disable watchdog
    WDTCTL = WDTPW + WDTHOLD;

    // Use 1 MHz DCO factory calibration
    DCOCTL = 0;
    BCSCTL1 = CALBC1_8MHZ;
    DCOCTL = CALDCO_8MHZ;


    // Setup pin 2 to be a digital read
    P2DIR = 0x00;


    // Setup the serial port
    // Serial out: P1.1 (BIT1)
    // Serial in:  P1.2 (BIT2)
    // Bit rate:   9600 (CPU freq / bit rate)
    //serial_setup(BIT1, BIT2, 1000000 / 9600);
    serial_setup(BIT1, BIT2, 8000000 / 9600);

    analogPinSelect( ANALOG_PIN );

    while(1){
    	msDelay(DELAY_MS);				//Create a 2 mS delay before doing the next read
    	i = analogRead();		//Store the raw analog value in i
    	pulse_detect(i);				//Pass the raw data into the pulse function
    	pulse_digital(P2IN);			// read digital
    	/* Creates a delay so that the terminal can keep up with the text */
    	if(DELAY_DISPLAY < display_counter){

    		printf("\r\nBPM:%i S:%i D:%i", BPM, i, digital_BPM);

    		/*
    		if(BPM > 20 && BPM < 300){// if in the correct range display this value
    			printf("\r\nBPM:%i S:%i D:%i", BPM, i, digital_BPM);
    		} else {// pulse outside the normal range of value
    			printf("\r\nS:%i D:%i", i, digital_BPM);
    		}
    		*/

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

/* Reads a digital signal either 1 or 0 and will create a BPM based on delay and the time between */
void pulse_digital(int Value){
//digital_IBI = 0, digital_BPM = 0, digital_counter = 0, digital_time = 0
	++digital_counter;

	if( (Value & BIT1) != 0){
		if(digital_pulse == 0){
			digital_time = digital_counter * DELAY_MS;

			// Fills the IBI array used to find BPM based on the past values
			digital_BPM = 0;
			for (j = 0; j <= (DIGITAL_VALUES - 2); j++) {       // shift data in the array
				digital_IBI[j] = digital_IBI[j+1];  			// and drop the oldest value
				digital_BPM += digital_IBI[j];
			}
			digital_IBI[DIGITAL_VALUES - 1] = digital_time;		// adds the newest value to the array
			digital_BPM += digital_time;
			digital_BPM /= DIGITAL_VALUES;
			digital_BPM = 60000/digital_BPM;		// average


			digital_counter = 0;		// Resets the pulse counter
			digital_pulse = 1;			// Determines that a pulse is current
		}
	} else {
		digital_pulse = 0;
	}
}

/* Accepts the analog signal and tries to determine the amount of time between beats */
void pulse_detect(int Signal){
	int max = 0, min = 1000, IBI = 0, deltaTime = 0;// temp values used to determine P and T

	//sampleCounter += DELAY_MS;// Increase the beat counter by the amount of delay will be used to determine time between beats
	//lastBeat = sampleCounter - lastBeatTime;// used to find how many mS since the last pulse


	// Fills the raw data array
	for (j = 0; j <= (RAW_VALUES - 2); j++) {              // shift data in the rawData array
		rawData[j] = rawData[j+1];       // and drop the oldest value
		if(rawData[j] < min)
			min = rawData[j];
		if(rawData[j] > max)
			max = rawData[j];
	}
	rawData[RAW_VALUES - 1] = Signal;				// adds the newest value to the rawData array


	// use the now set min and max values to set the P and T values of the pulse wave
	T = min;   		// T is the trough
	P = max;        // P is the peak

	// get amplitude of the pulse wave
	amp = P - T;
	thresh = amp/2 + T;// set thresh at 50% of the amplitude since people say the pulse happens at this point


	pulseCount = 0;
	Pulse = 0;
	for(j = 0; j < RAW_VALUES; j++){
		if(rawData[j] > thresh && Pulse == 0){
			if(pulseCount > 1){
				IBI += j - deltaTime;
			}

			++pulseCount;
			deltaTime = j;
			Pulse = 1;
		}

		if(rawData[j] < thresh && Pulse == 1){
			Pulse = 0;
		}
	}


	BPM = pulseCount * BPM_MULT; // turns the count into a value that can be used

	BPM = IBI * DELAY_MS;
	BPM /= pulseCount;
    BPM = 60000 / BPM;
}
