/*
 * canbridge.c
 *
 *  Created on: 2021年2月6日
 *      Author: WangXu
 */

#include "stm32f3xx_hal.h"
#include "canbridge.h"

void CalcCRC16(unsigned char *aStr)
{
	unsigned char alen = *aStr-2;   //CRC16只计算前两部分
	unsigned short xda , xdapoly ;
	unsigned char i,j, xdabit;

	xda = 0xFFFF;
	xdapoly = 0xA001 ;	// (X**16 + X**15 + X**2 + 1)

	for(i=0;i<alen;i++) {
		xda ^= aStr[i];
		for(j=0;j<8;j++) {
			xdabit = (unsigned char )(xda & 0x01);
			xda >>= 1;
			if(xdabit) xda ^= xdapoly;
		}
	}
	aStr[alen] = (unsigned char)(xda & 0xFF);
	aStr[alen+1] = (unsigned char)(xda >>8);
}

unsigned char CheckCRC16(unsigned char *aStr)
{
	unsigned char alen = *aStr-2;   //CRC16只计算前两部分
	unsigned short xda , xdapoly ;
	unsigned char i,j, xdabit ;
	unsigned char a, b;

	xda = 0xFFFF;
	xdapoly = 0xA001 ;	// (X**16 + X**15 + X**2 + 1)

	for(i=0;i<alen;i++) {
		xda ^= aStr[i];
		for(j=0;j<8;j++) {
			xdabit = (unsigned char )(xda & 0x01);
			xda >>= 1;
			if( xdabit ) xda ^= xdapoly;
		}
	}
	a = (unsigned char)(xda & 0xFF);
	b = (unsigned char)(xda >>8);
	if (aStr[alen] == a && aStr[alen+1] == b)
		return 1;
	else
		return 0;
}
