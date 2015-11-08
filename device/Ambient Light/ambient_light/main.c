#include "msp430g2553.h"
#include<stdlib.h>
#include<math.h>

#define ANALOG_PIN	7

// how many samples to take and average, more takes longer
// but is more 'smooth'
#define NUMSAMPLES 5

volatile unsigned int samples[NUMSAMPLES];
volatile float average;
//volatile unsigned int analogValue;


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


void main(void){

	unsigned int i;



  DCOCTL = CALDCO_1MHZ;
  BCSCTL1 = CALBC1_1MHZ;
  WDTCTL = WDTPW + WDTHOLD;


  // read adc repeatedly
  analogPinSelect(ANALOG_PIN);

  while(1){

	  //analogValue = analogRead();
	  for (i=0; i<NUMSAMPLES; i++) { //Go backwards because msp430 warning said it was better to detect zeros
	     samples[i] = analogRead();
	    // _delay_cycles(160000); //required delay/instruction cycle time = value in parenthesis, MCU=16MHz --> instruction cycle time =62.5ns

	    }

	  average = 0;
	  for (i=0; i<NUMSAMPLES; i++) {
	       average += samples[i];
	    }

	  average /= NUMSAMPLES;


  }
}

