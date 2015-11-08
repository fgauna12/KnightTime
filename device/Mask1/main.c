#include <msp430.h>

unsigned int i;
char Temp_Low;
char Temp_High;
char PEC;
char KnightTimeReplyFromDevice[3];			//This is the structure for a Knighttime packet incoming from the Decive.
char HBheart;
char LBheart;

void UART_Initialization(void);
void I2C_Initialization(void);
void Get_SkinTemp(void);
void msDelay(unsigned int msTime);

/*Heart Rate stuff*/
#define ANALOG_PIN      3				// The analog pin 7 is indicating that P1.7 is the analog
#define DELAY_MS		50				// How often the analog pin is read by the code 50 is the lowest stable number
#define IBI_VALUES		15				// The number of values used to create a BPM average
#define DELAY_DISPLAY	250/DELAY_MS	// Used to delay the printf so that it doesnt flood the terminal

/* Functions */
void pulse_detect(int Signal);
unsigned int analogRead();
void analogPinSelect(unsigned int pin);
void msDelayHeartRate(unsigned int msTime);

/* Variables */
volatile int BPM;                   	// used to hold the pulse rate
volatile int IBI = 600;             	// holds the time between beats, the Inter-Beat Interval
volatile int rate[IBI_VALUES];          // used to hold the most recent IBI values
volatile unsigned long sampleCounter = 0;// used to determine pulse timing
volatile unsigned long lastBeatTime = 0;// used to find the inter beat interval
volatile int P = 0;            			// used to find peak in pulse wave
volatile int T = 1000;             		// used to find trough in pulse wave
volatile int thresh = 500;           	// used to find instant moment of heart beat
volatile int amp = 100;              	// used to hold amplitude of pulse waveform
volatile int display_counter = 0;		// used for debugging and delays the printf display

char brightness = 0x00;

enum MessageID
{                                     //#, Description

    /* Wrist Peripheral Messages */
    MovementRequest=0,                   //0,
    MovementReply,                     //1,
    VibratorCommand,                   //2,

    /* Mask Peripheral Messages */
    TemperatureRequest,            //3,
    TemperatureReply,                  //4,
    HeartRateRequest,                  //5,
    HeartRateReply,                    //6,
    EegRequest,                        //7,
    EegReply,                          //8,
    BuzzerCommand,                     //9,
    LightArrayCommand,                 //10,

    /* Base Station Messages */
    AmbientTemperatureRequest,        //11,
    AmbientTemperatureReply,          //12,
    AmbientNoiseRequest,              //13,
    AmbientNoiseReply,                //14,
    AmbientLightRequest,              //15,
    AmbientLightReply,                //16,
    AmbientHumidityRequest,           //17,
    AmbientHumidityReply              //18,
 };




void main(void) {


	WDTCTL = WDTPW + WDTHOLD;                 // Stop WDT
	P2DIR |= BIT0;
	P2OUT = 0X00;
	UART_Initialization();                    // Initialize UART
	I2C_Initialization();                     // Initialize I2C

	__enable_interrupt() ;

	 analogPinSelect( ANALOG_PIN ); // Configures the analog read with the correct pin

	  while (1)
	  {
		  int HeartValue;
		  msDelayHeartRate(DELAY_MS);				//Create a mS delay before doing the next read
		      	HeartValue = analogRead();				//Store the raw analog value in i
		      	pulse_detect(HeartValue);				//Pass the raw data into the pulse function

		      	/* Creates a delay so that the terminal can keep up with the text used for debugging */
		      	//if(DELAY_DISPLAY < display_counter){
		      		//printf("\r\nBPM:%i S:%i", BPM, i);

		      	//	display_counter = 0;
		      //	}
		      //	++display_counter;

	  }


}


#pragma vector=USCIAB0RX_VECTOR
__interrupt void USCI0RX_ISR(void)
{
		enum MessageID id;


		while (!(IFG2&UCA0RXIFG));

		id = UCA0RXBUF;

		switch(id)
		{
			case TemperatureRequest:
			{
				Get_SkinTemp();
				i=0;
				id = TemperatureReply;

				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=(char)Temp_Low;;
				KnightTimeReplyFromDevice[2]=(char)Temp_High;

				UCB0CTL1 = UCSSEL_2 + UCSWRST;
				UCB0CTL1 &= ~UCSWRST;


				msDelay(100);

				while (i != (sizeof(KnightTimeReplyFromDevice)))
				{
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}

				break;
			}

			case HeartRateRequest:
			{

				i=0;
				id = HeartRateReply;

				 HBheart = (BPM & 0xFF00) >> 8;   //mask LSB, shift 8 bits to the right
			     LBheart = BPM & 0x00FF;             //mask MSB, no need to shift

				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=LBheart;
				KnightTimeReplyFromDevice[2]=HBheart;


				msDelay(100);

				while (i != (sizeof(KnightTimeReplyFromDevice)))
				{
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}


				break;

			}


			case EegRequest:
			{
				i=0;
				id = EegReply;

				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=0;
				KnightTimeReplyFromDevice[2]=0;

				msDelay(100);

				while (i != (sizeof(KnightTimeReplyFromDevice)))
				{
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}

				break;
			}


			case BuzzerCommand:
			{
				  while (!(IFG2&UCA0RXIFG));                // USCI_A0 TX buffer ready?
				  if (UCA0RXBUF==1)
				  {
					  P2OUT = BIT0;
				  }
				  else if (UCA0RXBUF==0)
				  {
					  P2OUT = 0X00;
				  }

				  break;
			}


			case LightArrayCommand:
			{
				  while (!(IFG2&UCA0RXIFG));                // USCI_A0 TX buffer ready?
				  if (UCA0RXBUF==1)
				  {
					  brightness++;

					  I2CbeginTransmission(0x20);
					  I2Cwrite(0x80);
					  I2Cwrite(0x8F);
					  I2Cwrite(0x0B);

					  //RGB LED 0-2
					  I2Cwrite(0xFF);	//0 TURN RED
					  I2Cwrite(0x00);	//1 TURN BLUE
					  I2Cwrite(0x3F);	//2	TURN GREEN

					  I2Cwrite(0x00);	//3 not used

					  //RGB LED 4-7
					  I2Cwrite(0x3F);	//4 TURN GREEN
					  I2Cwrite(0x00);	//5 TURN BLUE
					  I2Cwrite(0xFF);	//6 TURN RED

					  I2Cwrite(0x00);	//7 not used

					  I2Cwrite(brightness); //INCREMENT
					  //I2Cwrite(0xFF); //INCREMENT
					  I2Cwrite(0x00);
					  I2Cwrite(0xFF);//	TURN OFF/ON LED 0-2
					  I2Cwrite(0xFF);//   TURN OFF/ON LED 4-7
					  //I2Cwrite(0x92);
					  //I2Cwrite(0x94);
					  //I2Cwrite(0x98);
					  //I2Cwrite(0x90);
					  I2CendTransmission();

					  UCA0TXBUF = 'N';
				  }
				  else if (UCA0RXBUF==0)
				  {
					  brightness=0x00;
					  	  	  	  	  	  I2CbeginTransmission(0x20);
					 					  I2Cwrite(0x80);
					 					  I2Cwrite(0x8F);
					 					  I2Cwrite(0x0B);

					 					  //RGB LED 0-2
					 					  I2Cwrite(0xFF);	//0 TURN RED
					 					  I2Cwrite(0x00);	//1 TURN BLUE
					 					  I2Cwrite(0x3F);	//2	TURN GREEN

					 					  I2Cwrite(0x00);	//3 not used

					 					  //RGB LED 4-7
					 					  I2Cwrite(0x3F);	//4 TURN GREEN
					 					  I2Cwrite(0x00);	//5 TURN BLUE
					 					  I2Cwrite(0xFF);	//6 TURN RED

					 					  I2Cwrite(0x00);	//7 not used

					 					  I2Cwrite(0x00); //INCREMENT
					 					  //I2Cwrite(0xFF); //INCREMENT
					 					  I2Cwrite(0x00);
					 					  I2Cwrite(0x00);//	TURN OFF/ON LED 0-2
					 					  I2Cwrite(0x00);//   TURN OFF/ON LED 4-7
					 					  //I2Cwrite(0x92);
					 					  //I2Cwrite(0x94);
					 					  //I2Cwrite(0x98);
					 					  //I2Cwrite(0x90);
					 					  I2CendTransmission();
					  UCA0TXBUF = 'F';

				  }

				  break;
			}



			default:
			{
				UCA0TXBUF = 'Z';
				break;
			}

		}//end of switch

}//end of interrupt


void UART_Initialization(void)
{
  P1SEL |= BIT1 + BIT2;                      // P1.1,2 = USCI_A0 RXD/TXD
  P1SEL2 |= BIT1 + BIT2;					 // P1.1,2 = USCI_A0 RXD/TXD
  UCA0CTL1 |= UCSSEL_2;                      // SMCLK
  UCA0BR0 = 104;                             // 1MHz 9600	Table 15-5 in Family User Guide slau144i.pdf
  UCA0BR1 = 0;                               // 1MHz 9600
  UCA0MCTL = UCBRS0;                         // Modulation = 0x02
  UCA0CTL1 &= ~UCSWRST;                      // **Initialize USCI state machine**
  //IE2 |= UCA0TXIE;                         // Enable USCI_A0 TX interrupt
  IE2 |= UCA0RXIE;                           // Enable USCI_A0 RX interrupt
  //IE2 &= ~UCA0TXIE; 						 // Disable USCI_A0 TX interrupt
}

void I2C_Initialization(void)
{
  P1SEL |= BIT6 + BIT7;						// Assign I2C pins to USCI_B0
  P1SEL2 |= BIT6 + BIT7;                    // Assign I2C pins to USCI_B0
  UCB0CTL1 |= UCSWRST;                      // Enable SW reset
  UCB0CTL0 = UCMST + UCMODE_3 + UCSYNC;     // I2C Master, synchronous mode
  UCB0CTL1 = UCSSEL_2 + UCSWRST;            // Use SMCLK, keep SW reset
  UCB0BR0 = 11;                             // fSCL = SMCLK/11 = 95.3kHz //Used 24 for MLX90614
  UCB0BR1 = 0;
  UCB0I2CSA = 0x5A;                         // Slave Address	//MLX address = 5A
  UCB0CTL1 &= ~UCSWRST;                     // Clear SW reset, resume operation
  //IE2 |= UCB0TXIE;                        // Enable USCI_B0 TX interrupt
  //IE2 |= UCB0RXIE;                        // Enable USCI_B0 RX interrupt
}

void msDelay(unsigned int msTime)
{
	// Internal MCLK is running at 16 Mhz (1/16Mhz = 62.5nS per cycle of code).
	// MCLK = 16000000UL/16000 = 1 ms of real time. Can run a for LOOP that does delays for amount of msTime
	long counter;
	for ( counter = 0; counter <= msTime; counter++)
	__delay_cycles( 16000000/16000  );				// 1 millisecond delay
}



void Get_SkinTemp(void)
{

  UCB0CTL1 |= UCTR+UCTXSTT;
  UCB0TXBUF = 0x7;
  while (!(IFG2 & UCB0TXIFG));
  UCB0CTL1 &= ~UCTR;
  while (UCB0CTL1 & UCTXSTT);
  UCB0CTL1 |= UCTXSTT;
  while(!(IFG2 & UCB0RXIFG));
  Temp_Low=UCB0RXBUF;
  while(!(IFG2 & UCB0RXIFG));
  Temp_High=UCB0RXBUF;
  while(!(IFG2 & UCB0RXIFG));
  PEC=UCB0RXBUF;
  UCB0CTL1 |= UCTXSTP;
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
void msDelayHeartRate(unsigned int msTime){
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

		for (j=0; j<=(IBI_VALUES - 2); j++) {// shift data in the rate array
			rate[j] = rate[j+1];            // and drop the oldest IBI value
			runningTotal += rate[j];        // add up the oldest IBI values
		}
		rate[IBI_VALUES - 1] = IBI;           // add the latest IBI to the rate array
		runningTotal += rate[IBI_VALUES - 1]; // add the latest IBI to runningTotal
		runningTotal /= IBI_VALUES;           // average the IBI values
		BPM = 60000/runningTotal;          	  // how many beats can fit into a minute? that's BPM!
	}

	/* If a  heart beat has not been detected for 2.5 seconds than reset the variables */
	if (lastBeat > 2500) {	// Restore default values so that it can found again
		amp = 100;
		thresh = 500;
		P = 0;
		T = 1000;
	}
}
