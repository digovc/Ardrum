#ifndef ARDUINO

#include "Ardrum.h"

void setup()
{
	Ardrum::getI()->iniciar();
}

void loopW()
{
	Ardrum::getI()->loop();
}

unsigned int main(int argc, char *argv[], char *envp[])
{
	setup();

	while (true)
	{
		loopW();
	}

	return 0;
}

#endif