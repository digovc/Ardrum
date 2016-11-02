#include "Config.h"

#pragma region Atributos

static Config *_i;

Config * Config::getI()
{
	if (_i != nullptr)
	{
		return _i;
	}

	_i = new Config();

	return _i;
}

#pragma endregion

#pragma region Construtores

Config::Config()
{
}

#pragma endregion

#pragma region Metodos

#pragma endregion