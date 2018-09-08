#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Wine::Wine(Names n) : Alcohol(n) 
{
	switch (n)
	{
	case Merlo:
		Name = "Merlo";
		break;
	case Bordo:
		Name = "Bordo";
		break;
	case Sotern:
		Name = "Sotern";
		break;
	default:
		throw exception("Invalid name.");
		break;
	}
}
Wine::Wine(const Wine &Q) : Alcohol(Q)
{
	type = Q.type;
	WType = Q.WType;
}
void Wine::Set_Volume(double new_volume)
{
	if (new_volume <= 0)
		throw exception("Invalid volume. ");
	volume = new_volume;
}
void Wine::Set_WType(int buff)
{
	switch (buff)
	{
	case dry:
		WType = "dry";
		type = dry;
		percent = 11;
		break;
	case semi_dry:
		WType = "semi-dry";
		type = semi_dry;
		percent = 10.5;
		break;
	case semi_sweet:
		WType = "semi-sweet";
		type = semi_sweet;
		percent = 9;
		break;
	default:
		throw exception("Invalid type!");
		break;
	}
}
double Wine::Get_Percent()
{ 
	Set_WType(type);
	return percent; 
}
string Wine::Get_Type() { return WType; }
string Wine::Get_Name() { return Name; }
Wine::~Wine() {}

ostream & operator<<(ostream &out, const Wine &Q)
{
	out << "Name: " << Q.Name << endl;
	out << "Volume: " << Q.volume << endl;
	out << "Type: " << Q.WType << endl;
	return out;
}

istream & operator >> (istream &in, Wine &Q)
{
	int buff = 0;
	in >> Q.volume;
	Q.Set_Volume(Q.volume);
	in >> buff;
	Q.Set_WType(buff);
	return in;
}