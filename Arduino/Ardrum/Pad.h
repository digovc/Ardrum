#ifndef Pad_h
#define Pad_h

#include "Config.h"

#if defined(ARDUINO)
#include <Arduino.h>
#else
#include "Arduino.h"
#endif

class Pad
{
#pragma region Atributos

private:

	bool _booTocou;

	bool getBooTocou();

	void setBooTocou(bool booTocou);

	unsigned int _intPino;

	unsigned int getIntPino();

	void setIntPino(unsigned int intPino);

	long _lngUltimoToque;

	long getLngUltimoToque();

	void setLngUltimoToque(unsigned long lngUltimoToque);

#pragma endregion

#pragma region Construtores

public:
	Pad();

#pragma endregion

#pragma region Metodos

public:

	void iniciar(unsigned int intPino);

	void loop();

private:

	void verificarToque();

#pragma endregion
};

#endif // Pad