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

	void loop();

private:

	Ardrum();

	Pad _arrPad[Config::INT_PAD_QUANTIDADE];

	Pad *getArrPad();

	void iniciarArrPad();

	void loopArrPad();
};

#endif // !Ardrum_h
