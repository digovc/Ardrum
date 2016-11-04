#ifndef Pad_h
#define Pad_h

#include "Config.h"
#include "Server.h"

#if defined(ARDUINO)
#include <Arduino.h>
#else
#include "Arduino.h"
#endif

class Pad
{
#pragma region Atributos

private:

	bool _booEnviar;

	bool getBooEnviar();

	void setBooEnviar(bool booEnviar);

	bool _booTocou;

	bool getBooTocou();

	void setBooTocou(bool booTocou);

	unsigned int _intForca;

	unsigned int getIntForca();

	void setIntForca(unsigned int intForca);

	unsigned int _intPino;

	unsigned int getIntPino();

	void setIntPino(unsigned int intPino);

	unsigned long _lngUltimoToque;

	unsigned long getLngUltimoToque();

	void setLngUltimoToque(unsigned long lngUltimoToque);

#pragma endregion

#pragma region Construtores

public:
	Pad();

#pragma endregion

#pragma region Metodos

public:

	void iniciar(unsigned int intPino);

	void loop(const unsigned long lngMillis);

private:

	void enviar();

	void verificarToque(const unsigned long lngMillis);

#pragma endregion
};

#endif // Pad