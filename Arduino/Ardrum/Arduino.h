#ifndef Arduino_h
#define Arduino_h

#define HIGH 1
#define LOW  0

#define INPUT 0
#define OUTPUT 1
#define INPUT_PULLUP 2

unsigned int analogRead(int intPino);

unsigned long millis();

class SerialClass
{
public:

	void begin(long lngBaud);

	void print(char *strMsg);

	void print(unsigned int intMsg);

	void println(char *strMsg);
};

#endif