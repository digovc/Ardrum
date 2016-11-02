#ifndef Ardrum_h
#define Ardrum_h

#include "Config.h"
#include "Pad.h"
#include "Server.h"

class Ardrum
{
public:

	static Ardrum *getI();

	void iniciar();

	void loop(const unsigned long lngMillis);

private:

	Ardrum();

	Pad _arrPad[Config::INT_PAD_QUANTIDADE];

	Pad *getArrPad();

	void iniciarArrPad();

	void loopArrPad(const unsigned long lngMillis);
};

#endif // !Ardrum_h
