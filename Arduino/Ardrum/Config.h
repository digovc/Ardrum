#ifndef Config_h
#define Config_h

class Config
{
public:

	static const unsigned int INT_PAD_QUANTIDADE = 2;
	static const unsigned int INT_PAD_THRESHOLD = 500;
	static const unsigned int INT_PAD_TOQUE_INTERVALO = 5;
	static const unsigned long LNG_SERIAL_VELOCIDADE = 9600;

	static Config *getI();

private:

	Config();
};

#endif // !Config_h
