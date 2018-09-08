#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Beer::Beer(Names n) :Alcohol(n) 
{
	switch (n)
	{
	case Carlsberg:
		Name = "Carlsberg";
		break;
	case Baltica:
		Name = "Baltica";
		break;
	case Lidskoe:
		Name = "Lidskoe";
		break;
	default:
		throw exception("Invalid name.");
		break;
	}
}
Beer::Beer(const Beer &Q) : Alcohol(Q)
{
	type = Q.type;
	BType = Q.BType;
}
void Beer::Set_Volume(double new_volume)
{
	if (new_volume <= 0)
		throw exception("Invalid volume. ");
	volume = new_volume;
}
void Beer::Set_Type(int buff)
{
	switch (buff)
	{
	case dark:
		type = dark;
		BType = "dark";
		percent = 3.5;
		break;
	case light:
		type = light;
		BType = "light";
		percent = 5;
		break;
	case live:
		type = light;
		BType = "live";
		percent = 4.5;
		break;
	case non_filtered:
		type = non_filtered;
		BType = "non-filtered";
		percent = 7;
		break;
	default:
		throw exception("Invalid type!");
		break;
	}
}
double Beer::Get_Percent()
{
	Set_Type(type);
	return percent; 
}
string Beer::Get_Type() { return BType; }
string Beer::Get_Name() { return Name; }
Beer::~Beer() {}

ostream & operator<<(ostream &out, const Beer &Q)
{
	out << "Name: " << Q.Name << endl;
	out << "Volume: " << Q.volume << endl;
	out << "Type: " << Q.BType << endl;
	out << "Percent of alcohol: " << Q.percent << endl;
	return out;
}

istream & operator >> (istream &in, Beer &Q)
{
	int buff = 0;
	in >> Q.volume;
	Q.Set_Volume(Q.volume);
	in >> buff;
	Q.Set_Type(buff);
	return in;
}
