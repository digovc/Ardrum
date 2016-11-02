#include "Pad.h"

#pragma region Atributos

bool Pad::getBooTocou()
{
	return _booTocou;
}

void Pad::setBooTocou(bool booTocou)
{
	_booTocou = booTocou;
}

unsigned int Pad::getIntPino()
{
	return _intPino;
}

void Pad::setIntPino(unsigned int intPino)
{
	_intPino = intPino;
}

long Pad::getLngUltimoToque()
{
	return _lngUltimoToque;
}

void Pad::setLngUltimoToque(unsigned long lngUltimoToque)
{
	_lngUltimoToque = lngUltimoToque;
}

#pragma endregion

#pragma region Construtores

Pad::Pad()
{
}

#pragma endregion

#pragma region Metodos

void Pad::iniciar(unsigned int intPino)
{
	this->setIntPino(intPino);
}

void Pad::loop(const unsigned long lngMillis)
{
	this->verificarToque(lngMillis);
}

void Pad::verificarToque(const unsigned long lngMillis)
{
	if (this->getBooTocou())
	{
		return;
	}

	if ((lngMillis - this->getLngUltimoToque()) < Config::INT_PAD_TOQUE_INTERVALO)
	{
		return;
	}

	unsigned int intPinoValor = analogRead(this->getIntPino());

	if (intPinoValor < Config::INT_PAD_THRESHOLD)
	{
		return;
	}

	this->setBooTocou(true);

	this->setLngUltimoToque(lngMillis);
}

#pragma endregion