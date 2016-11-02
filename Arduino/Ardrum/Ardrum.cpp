#include "Ardrum.h"

#pragma region Atributos

static Ardrum *_i;

Pad *Ardrum::getArrPad()
{
	return _arrPad;
}

Ardrum * Ardrum::getI()
{
	if (_i != nullptr)
	{
		return _i;
	}

	_i = new Ardrum();

	return _i;
}

#pragma endregion

#pragma region Construtores

Ardrum::Ardrum()
{
}

#pragma endregion

#pragma region Metodos

void Ardrum::iniciar()
{
	Server::getI()->iniciar();

	this->iniciarArrPad();
}

void Ardrum::iniciarArrPad()
{
	for (unsigned int i = 0; i < Config::INT_PAD_QUANTIDADE; i++)
	{
		this->getArrPad()[i].iniciar(i);
	}
}

void Ardrum::loop()
{
	this->loopArrPad();
}

void Ardrum::loopArrPad()
{
	for (unsigned int i = 0; i < Config::getI()->INT_PAD_QUANTIDADE; i++)
	{
		this->getArrPad()[i].loop();
	}
}

#pragma endregion