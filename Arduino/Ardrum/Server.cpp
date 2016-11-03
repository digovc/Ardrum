#include "Server.h"

#pragma region Atributos

static Server *_i;

Server * Server::getI()
{
	if (_i != nullptr)
	{
		return _i;
	}

	_i = new Server();

	return _i;
}

#if defined(ARDUINO)
#else
SerialClass Serial;
#endif

#pragma endregion

#pragma region Construtores

Server::Server()
{
}

#pragma endregion

#pragma region Metodos

void Server::enviarToque(unsigned int intPino, unsigned int intForca)
{	
	// TODO: Implementar validação para não permitir estouro do buffer da porta serial.

	Serial.print(intPino);
	Serial.print(intForca);
	Serial.print("\n");
}

void Server::iniciar()
{
	Serial.begin(Config::getI()->LNG_SERIAL_VELOCIDADE);
	Serial.println(0);
}

#pragma endregion