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

void Pad::loop()
{
	this->verificarToque();
}

void Pad::verificarToque()
{
	if (this->getBooTocou())
	{
		return;
	}

	if ((millis() - this->getLngUltimoToque()) < Config::INT_PAD_TOQUE_INTERVALO)
	{
		return;
	}

	unsigned int intPinoValor = analogRead(this->getIntPino());

	if (intPinoValor < Config::INT_PAD_THRESHOLD)
	{
	}
}

#pragma endregion