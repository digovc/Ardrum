#ifndef Server_h
#define Server_h

#include "Config.h"

#if defined(ARDUINO)
#include <Arduino.h>
#else
#include "Arduino.h"
#endif

class Server
{
public:

	static Server *getI();

	void iniciar();

private:

	Server();
};

#endif // !Server_h
