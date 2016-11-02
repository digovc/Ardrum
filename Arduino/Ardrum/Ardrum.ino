#include "Ardrum.h"

void setup()
{
	Ardrum::getI()->iniciar();
}

void loop()
{
	Ardrum::getI()->loop();
}