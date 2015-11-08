#include <msp430.h>

#define TST(x,y)	(x & (y))
#define SET(x,y)	(x|= (y))
#define CLR(x,y)	(x &= ~(y))
#define TOG(x,y)	(x ^= (y))

#define DPIN BIT3

extern unsigned char volatile TOUT;
#define ANALOG_PIN	0
#define ANALOG_PIN_NOISE 4
#define NUMSAMPLES 5

volatile unsigned int samples[NUMSAMPLES];
unsigned int average;
unsigned int LightValue;
unsigned int NoiseValue;
char LBlight;
char HBlight;
char LBnoise;
char HBnoise;

/*
 * This is the structure for a Knighttime packet incoming from the Decive.
 */
char KnightTimeReplyFromDevice[3];

unsigned int i;

unsigned char RH_byte1;
unsigned char RH_byte2;
unsigned char T_byte1;
unsigned char T_byte2;
unsigned char checksum;

unsigned char Packet[5];
float Humidity;
float Temperature;

unsigned char volatile TOUT;			//REQUIRED for library
unsigned char volatile SECOND_TIMER=0;

void init(void);
void start_Signal(void);
unsigned char check_Response(void);
unsigned char read_Byte(void);
unsigned char read_Packet(unsigned char *);		//Pass an array with 5 elements
unsigned char check_Checksum(unsigned char *);	//Pass an array with 5 elements
float getTemperature(unsigned char *);
float getHumidity(unsigned char *);
unsigned int analogRead();
void analogPinSelect(unsigned int pin);
void AmbientLight();
void AmbientNoise();
void AmbientHumidTemp();
void msDelay(unsigned int msTime);

#pragma vector = TIMER0_A0_VECTOR
__interrupt void CCR0_ISR(void){
		SECOND_TIMER++;
		TOUT=1;
		//TOG (P1OUT,0x01);
		CLR (TACCTL0, CCIFG);
}

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
	init();
	 P1SEL = BIT1 + BIT2 ;                     // P1.1 = RXD, P1.2=TXD
	 P1SEL2 = BIT1 + BIT2 ;                    // P1.1 = RXD, P1.2=TXD

	 UCA0CTL1 |= UCSSEL_2;                     // SMCLK
	 UCA0BR0 = 104;                            // 1MHz 9600
	 UCA0BR1 = 0;                              // 1MHz 9600
	 UCA0MCTL = UCBRS0;                        // Modulation UCBRSx = 1
	 UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
	 IE2|=UCA0RXIE;

	while(1){
		//AmbientHumidTemp();
		AmbientNoise();
	//__bis_SR_register(LPM0_bits + GIE);       // Enter LPM0, interrupts enabled

	}//end of while loop


}




//This is the receiving interrupt
#pragma vector=USCIAB0RX_VECTOR
__interrupt void USCI0RX_ISR(void)
{
	enum MessageID id;

	//char id; //use this for testing sending a char
	while (!(IFG2&UCA0RXIFG));

	//id = UCA0RXBUF; //need this for bluetooth app on my phone -'0';
	id = UCA0RXBUF;
	switch(id)
		{


	        /* Dock Peripheral Messages */
			case AmbientHumidityRequest:
			{
				AmbientHumidTemp();
				i=0;
				id = AmbientHumidityReply;


				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=(char)RH_byte2;
				KnightTimeReplyFromDevice[2]=(char)RH_byte1;

				while (i != (sizeof(KnightTimeReplyFromDevice))){
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}


				 break;
			}

			case AmbientTemperatureRequest:
			{
				AmbientHumidTemp();
				i=0;
				id = AmbientTemperatureReply;

				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=(char)T_byte2;
				KnightTimeReplyFromDevice[2]=(char)T_byte1;

				while (i != (sizeof(KnightTimeReplyFromDevice))){
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}


				break;
			}

			case AmbientLightRequest:
			{

				AmbientLight();
				i=0;
				id = AmbientLightReply;


				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=(char)LBlight;
				KnightTimeReplyFromDevice[2]=(char)HBlight;

				while (i != (sizeof(KnightTimeReplyFromDevice))){
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}


				break;
			}


			case AmbientNoiseRequest:
			{
				//AmbientNoise();
				i=0;
				id = AmbientNoiseReply;


				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=(char)LBnoise;
				KnightTimeReplyFromDevice[2]=(char)HBnoise;

				while (i != (sizeof(KnightTimeReplyFromDevice))){
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}
				NoiseValue = 0;

				break;
			}

			default:
			{
				UCA0TXBUF = 'p';
				break;
			}

		}



}


void init(){
	WDTCTL = WDTPW + WDTHOLD;	// Stop watchdog timer

	//P1OUT  = 0x00;				//Start with nothing being output
	//P1DIR  = 0x41;				// Set LED to output direction

	BCSCTL1 = CALBC1_1MHZ; 		// Set oscillator to 1MHz
	DCOCTL = CALDCO_1MHZ;  		// Set oscillator to 1MHz

	TACCR0 = 50000;				// Initialize the timer to count at 5Hz
	TACCTL0 = CCIE;				// Enable interrupt
	TA0CTL = TASSEL_2 + ID_2 + MC_1 + TACLR;	// SMCLK, div 4, up mode,
												// clear timer
	_enable_interrupt();						//Enable global interrupt
}



unsigned char read_Byte(){
	TOUT = 0;
	unsigned char num = 0;
	unsigned char i;
	CLR(TACCTL0,CCIE);
	for (i=8; i>0; i--){
		while(!(TST(P1IN,DPIN))); //Wait for signal to go high
		SET(TACTL,TACLR); //Reset timer
		SET(TA0CTL,0x10); //Reenable timer
		SET(TACCTL0,CCIE); //Enable timer interrupt
		while(TST(P1IN,DPIN)); //Wait for signal to go low
		CLR(TA0CTL,0x30); //Halt Timer
		if (TAR > 13)	 //40 @ 1x divider
			num |= 1 << (i-1);
	}
	return num;
}

unsigned char read_Packet(unsigned char * data){
	start_Signal();
	if (check_Response()){
		//Cannot be done with a for loop!
		data[0] = read_Byte();
		data[1] = read_Byte();
		data[2] = read_Byte();
		data[3] = read_Byte();
		data[4] = read_Byte();
		return 1;
	}
	else return 0;
}

unsigned char check_Response(){
	TOUT=0;
	SET(TACTL,TACLR); 	//Reset timer to 0;
	TACCR0 = 25;		//Set timer to overflow in 100uS. 100 @ 1x divider
	SET(TACCTL0,CCIE); 	//And enable timer interrupt
	while(!(TST(P1IN,DPIN)) && !TOUT);
	if (TOUT)
		return 0;
	else {
		SET(TACTL,TACLR);
		SET(TACCTL0,CCIE);
		while((TST(P1IN,DPIN)) && !TOUT);
		if(TOUT)
			return 0;
		else{
			CLR(TACCTL0,CCIE);	// Disable timer interrupt
			return 1;
		}
	}
}

void start_Signal(){
	SET(P1DIR, DPIN);		// Set Data pin to output direction
	CLR(P1OUT,DPIN); 		// Set output to low
	__delay_cycles(25000); 	// Low for at least 18ms
	SET(P1OUT,DPIN);
	__delay_cycles(30);		// High for at 20us-40us
	CLR(P1DIR,DPIN);		// Set data pin to input direction
}

//returns true if checksum is correct
unsigned char check_Checksum(unsigned char *data){
	if (data[4] != (data[0] + data[1] + data[2] + data[3])){
		return 0;
	}
	else return 1;
}

float getTemperature(unsigned char *Packet){
	float temp;

	temp= ((Packet[2] & 0x7F)*256 + Packet[3])/10.0;
	//temp = temp *256;
	//temp = temp + Packet[3];
	//temp = temp/10;

	return temp;
}

float getHumidity(unsigned char *Packet){
	float humid;



	humid= ((Packet[0]*256)+Packet[1])/10.0;
	//humid = humid *256;
	//humid = humid + Packet[1];
	//humid = humid/10;

	return humid;
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

void AmbientLight(){
	analogPinSelect(ANALOG_PIN);
	 LightValue = analogRead();





		 HBlight = (LightValue & 0xFF00) >> 8;   //mask LSB, shift 8 bits to the right
	     LBlight = LightValue & 0x00FF;             //mask MSB, no need to shift

}



void AmbientNoise()
{
	unsigned int temp_ambientNoise = 0;
	analogPinSelect(ANALOG_PIN_NOISE);

	//for (i=0; i<NUMSAMPLES; i++) {
		//	     samples[i] = analogRead();
	//	}

		//average = 0;
		//for (i=0; i<NUMSAMPLES; i++) {
		//	average += samples[i];
		//}

			//average /= NUMSAMPLES;


	temp_ambientNoise = analogRead(); //changed this to an unsigned int or volatile

	NoiseValue = (temp_ambientNoise > NoiseValue)? temp_ambientNoise : NoiseValue;

	HBnoise = (NoiseValue & 0xFF00) >> 8;   //mask LSB, shift 8 bits to the right
	LBnoise = NoiseValue & 0x00FF;             //mask MSB, no need to shift

}

void AmbientHumidTemp(){

	//if(SECOND_TIMER >= 5){		//5 @ CCR0 = 50000 & div 4
	 msDelay(1000);
				//	Simple way to gather all data with one instruction
				read_Packet(Packet);
				RH_byte1 =	Packet[0];
				RH_byte2 =	Packet[1];
				T_byte1 =	Packet[2];
				T_byte2 =	Packet[3];
				checksum =	Packet[4];

				if (check_Checksum(Packet)){
					//SET (P1OUT, 0x40);
				}

				SET (TACTL, TACLR);
				SET (TA0CTL, 0x10);
				TACCR0 = 50000;		//Initialize the timer to count at 5Hz
				SECOND_TIMER = 0;	//Clear counter


			//}
}


void msDelay(unsigned int msTime)
{
	// Internal MCLK is running at 16 Mhz (1/16Mhz = 62.5nS per cycle of code).
	// MCLK = 16000000UL/16000 = 1 ms of real time. Can run a for LOOP that does delays for amount of msTime
	long counter;
	for ( counter = 0; counter <= msTime; counter++)
	__delay_cycles( 16000000/16000  );				// 1 millisecond delay
}
