#include "msp430g2553.h"

void serial_setup(unsigned out_mask, unsigned in_mask, unsigned duration);

void printf(char *, ...);

void main(void)
{
    char *s;
    char c;
    int i;
    unsigned u;
    long int l;
    long unsigned n;
    unsigned x;

    // Disable watchdog
    WDTCTL = WDTPW + WDTHOLD;

    // Use 1 MHz DCO factory calibration
    DCOCTL = 0;
    BCSCTL1 = CALBC1_1MHZ;
    DCOCTL = CALDCO_1MHZ;

    // Setup the serial port
    // Serial out: P1.1 (BIT1)
    // Serial in:  P1.2 (BIT2)
    // Bit rate:   9600 (CPU freq / bit rate)
    serial_setup(BIT1, BIT2, 1000000 / 9600);

    printf("%s", "\r\n*** printf() test ***\r\n");

    s = "test";
    c = 'X';
    i = -12345;
    u =  12345;
    l = -1234567890;
    n =  1234567890;
    x = 0xABCD;

    printf("String        %s\r\n", s);
    printf("Char          %c\r\n", c);
    printf("Integer       %i\r\n", i);
    printf("Unsigned      %u\r\n", u);
    printf("Long          %l\r\n", l);
    printf("uNsigned loNg %n\r\n", n);
    printf("heX           %x\r\n", x);

    printf("multiple args %s %c %i %u %l %n %x\r\n", s, c, i, u, l, n, x);

    printf("\r\n*** Done ***\r\n");

    for(;;);
}
