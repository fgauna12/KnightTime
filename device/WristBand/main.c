#include <msp430.h>
#include "MSP430_MPU6050.h"
#include "MPU6050.h"
#include <stdint.h>
#include "I2C_MSP430.h"
//#include "msp430g2553.h"


char KnightTimeReplyFromDevice[13];				// This is the structure for a KnightTime packet incoming from the Device.

unsigned int i;
static int8_t axh, axl, ayh, ayl, azh, azl;		// Holds the raw accelerometer data.
static int8_t gxh, gxl, gyh, gyl, gzh, gzl;		// Holds the raw gyroscope data.


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

int main(void)
{


		WDTCTL = WDTPW + WDTHOLD;                 	// Stop WDT

		  if (CALBC1_1MHZ==0xFF)					// If calibration constant erased
		  {
		    while(1);                               // do not load, trap CPU!!
		  }
		  DCOCTL = 0;                               // Select lowest DCOx and MODx settings
		  BCSCTL1 = CALBC1_1MHZ;                    // Set DCO
		  DCOCTL = CALDCO_1MHZ;
		  P2DIR |= 0X08;
		  UCA0CTL1 |= UCSSEL_2;                     // SMCLK
		  UCA0BR0 = 104;                            // 1MHz 9600
		  UCA0BR1 = 0;                              // 1MHz 9600
		  UCA0MCTL = UCBRS0;                        // Modulation UCBRSx = 1
		  UCA0CTL1 &= ~UCSWRST;                     // **Initialize USCI state machine**
		  IE2|=UCA0RXIE;
		  //P2OUT = BIT3;
		  P2OUT = 0X00;
		  P1DIR |= BIT0;                            // P1.0 output
		  P1SEL |= BIT1 + BIT2 + BIT6 + BIT7;       // Assign I2C pins to USCI_B0, SDA:P1.7, SCL: P1.6, RX:P1.1, TX:P1.2
		  P1SEL2|= BIT1 + BIT2 + BIT6 + BIT7;



		  //initializeIMU();							// Initialize IMU

		  //getIMUdata(&axh, &axl, &ayh, &ayl, &azh, &azl, &gxh, &gxl, &gyh, &gyl, &gzh, &gzl);

		//  msDelay(30);								// Temporary wait. Can be shortened

		  for(;;){
		  __bis_SR_register(CPUOFF + GIE);       // Enter LPM0, interrupts enabled
		  }
}



#pragma vector=USCIAB0RX_VECTOR
__interrupt void USCI0RX_ISR(void)
{
	enum MessageID id;

	while (!(IFG2&UCA0RXIFG));

						/*If using S2 Bluetooth App for testing send 32 (ascii for 2) to the phone.*/
	//id = UCA0RXBUF-'0'; // Subtract by '0' for S2 Bluetooth App (Use for Testing/Debugging)
	id = UCA0RXBUF;		// Use this line for KnightTime App

	switch(id)
	{


	        /* Wrist Peripheral Messages */
			case MovementRequest:
			{
				i=0;
				id = MovementReply;
				initializeIMU();							// Initialize IMU
				getIMUdata(&axh, &axl, &ayh, &ayl, &azh, &azl, &gxh, &gxl, &gyh, &gyl, &gzh, &gzl); // Gets the IMU data

				KnightTimeReplyFromDevice[0]=(char)id;
				KnightTimeReplyFromDevice[1]=(char)axl;
				KnightTimeReplyFromDevice[2]=(char)axh;
				KnightTimeReplyFromDevice[3]=(char)ayl;
				KnightTimeReplyFromDevice[4]=(char)ayh;
				KnightTimeReplyFromDevice[5]=(char)azl;
				KnightTimeReplyFromDevice[6]=(char)azh;
				KnightTimeReplyFromDevice[7]=(char)gxl;
				KnightTimeReplyFromDevice[8]=(char)gxh;
				KnightTimeReplyFromDevice[9]=(char)gyl;
				KnightTimeReplyFromDevice[10]=(char)gyh;
				KnightTimeReplyFromDevice[11]=(char)gzl;
				KnightTimeReplyFromDevice[12]=(char)gzh;

				msDelay(100);

				while (i != (sizeof(KnightTimeReplyFromDevice))){	// This send every byte in the Array
					UCA0TXBUF = KnightTimeReplyFromDevice[i++];
					__delay_cycles(1000);
					while (!(IFG2&UCA0TXIFG));
					__delay_cycles(1000);
				}


				 break;
			}

			case VibratorCommand:
			{
				  while (!(IFG2&UCA0RXIFG));                // USCI_A0 TX buffer ready?
				  	  if (UCA0RXBUF==1){
				  		  P2OUT = BIT3;
				  		 // UCA0TXBUF = 'N';
				  	  }										//This is for testing
				  			else if (UCA0RXBUF==0){
				  				P2OUT = 0X00;
				  				//UCA0TXBUF = 'F'; 			//This is for testing
				  			}

				break;
			}

		}



}
