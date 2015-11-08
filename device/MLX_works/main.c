#include "msp430g2553.h"
#include "mlx.h"

float temperature;
void serial_setup(unsigned out_mask, unsigned in_mask, unsigned duration);

void printf(char *, ...);


void main(void)
{
  WDTCTL = WDTPW + WDTHOLD;                 // Stop WDT
  //initalize(0x5A);
  //setslaveaddress(0x5A);
  // Setup the serial port
  	  // Serial out: P1.1 (BIT1)
  	  // Serial in:  P1.2 (BIT2)
  	  // Bit rate:   9600 (CPU freq / bit rate)
  	  serial_setup(BIT1, BIT2, 1000000 / 9600);

  	  printf("\r\n %s \r\n", "Temperature");

  for (;;)
  	{
	  initalize(0x5A);
	  temperature = get_temp();
	  printf("%i\r\n", temperature);



  	}


}
