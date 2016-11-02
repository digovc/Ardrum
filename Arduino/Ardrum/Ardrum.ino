#include "Ardrum.h"

unsigned long lngMillis = -1;

void setup()
{
	Ardrum::getI()->iniciar();
}

void loop()
{
	lngMillis = millis();
	
	Ardrum::getI()->loop(lngMillis);
}