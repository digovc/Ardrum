#include "Pad.h"

#pragma region Atributos

bool Pad::getBooEnviar()
{
	return _booEnviar;
}

void Pad::setBooEnviar(bool booRepousou)
{
	_booEnviar = booRepousou;
}

bool Pad::getBooTocou()
{
	return _booTocou;
}

void Pad::setBooTocou(bool booTocou)
{
	_booTocou = booTocou;
}

unsigned int Pad::getIntForca()
{
	return _intForca;
}

void Pad::setIntForca(unsigned int intForca)
{
	_intForca = intForca;
}

unsigned int Pad::getIntPino()
{
	return _intPino;
}

void Pad::setIntPino(unsigned int intPino)
{
	_intPino = intPino;
}

unsigned long Pad::getLngUltimoToque()
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

void Pad::enviar()
{
	if (!this->getBooEnviar())
	{
		return;
	}

	if (!this->getBooTocou())
	{
		return;
	}

	Server::getI()->enviarToque(this->getIntPino(), this->getIntForca());

	this->setBooEnviar(false);
}

void Pad::iniciar(unsigned int intPino)
{
	this->setBooEnviar(true);
	this->setBooTocou(false);
	this->setIntPino(intPino);
	this->setLngUltimoToque(-1);
}

void Pad::loop(const unsigned long lngMillis)
{
	this->verificarToque(lngMillis);
	this->enviar();
}

void Pad::verificarToque(const unsigned long lngMillis)
{
	if (this->getBooEnviar() && this->getBooTocou())
	{
		return;
	}

	if ((lngMillis - this->getLngUltimoToque()) < Config::INT_PAD_TOQUE_INTERVALO)
	{
		return;
	}

	this->setIntForca(analogRead(this->getIntPino()));

	if (this->getIntForca() < 1)
	{
		this->setBooEnviar(true);
		this->setBooTocou(false);
		return;
	}

	if (this->getIntForca() < Config::INT_PAD_THRESHOLD)
	{
		return;
	}

	this->setBooTocou(true);
	this->setLngUltimoToque(lngMillis);
}

#pragma endregion