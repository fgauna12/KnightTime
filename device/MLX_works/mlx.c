#include "mlx.h"
float temp;
unsigned char temp_low;
unsigned char temp_high;
unsigned char PEC;



void initalize ( char sladdress )
{
  P1SEL |= BIT6 + BIT7;
  P1SEL2 |= BIT6 + BIT7;
  UCB0CTL1 |= UCSWRST;
  UCB0CTL0 = UCMST + UCMODE_3 + UCSYNC;
  UCB0BR0 = 24;
  UCB0BR1 = 0;
  UCB0I2CSA = sladdress;
  UCB0CTL1 = UCSSEL_2 + UCSWRST;
  UCB0CTL1 &= ~UCSWRST;
}

float get_temp(void)
{
  UCB0CTL1 |= UCTR+UCTXSTT;
  UCB0TXBUF = 0x7;
  while (!(IFG2 & UCB0TXIFG));
  UCB0CTL1 &= ~UCTR;
  while (UCB0CTL1 & UCTXSTT);
  UCB0CTL1 |= UCTXSTT;
  while(!(IFG2 & UCB0RXIFG));
  temp_low=UCB0RXBUF;
  while(!(IFG2 & UCB0RXIFG));
  temp_high=UCB0RXBUF;
  while(!(IFG2 & UCB0RXIFG));
  PEC=UCB0RXBUF;
  UCB0CTL1 |= UCTXSTP;
  temp =  ((temp_high << 8) |temp_low);
  temp=temp/50-273;
  temp=(1.8)*temp+32;
  return temp;
}
