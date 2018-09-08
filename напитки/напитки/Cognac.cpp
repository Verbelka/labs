#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Cognac::Cognac(Names n) : Alcohol(n)
{
	switch (n)
	{
	case Ararat:
		Name = "Ararat";
		break;
	case Shabo:
		Name = "Shabo";
		break;
	case Martell:
		Name = "Martell";
		break;
	default:
		throw exception ("Invalid name.");
		break;
	}
}
Cognac::Cognac(const Cognac &Q) : Alcohol(Q)
{
	type = Q.type;
	CType = Q.CType;
	rating = Q.rating;
}
void Cognac::Set_Volume(double new_volume)
{
	if (new_volume <= 0)
		throw exception("Invalid volume. ");
	volume = new_volume;
}
void Cognac::Set_CType(int buff)
{
	switch (buff)
	{
	case old:
		CType = "old";
		type = old;
		percent = 40;
		break;
	case very_old:
		CType = "very old";
		type = very_old;
		percent = 50;
		break;
	case special:
		CType = "special";
		type = special;
		percent = 57;
		break;
	default:
		throw exception("Invalid type!");
		break;
	}
}
int Cognac::Get_Rating(C_types t)
{
	switch (t)
	{
	case old:
		rating = 3;
		break;
	case very_old:
		rating = 4;
		break;
	case special:
		rating = 5;
		break;
	}
	return rating;
}

double Cognac::Get_Percent()
{
	Set_CType(type);
	return percent;
}
string Cognac::Get_Type() { return CType; }
C_types Cognac::Get_type()
{
	return type;
}
string Cognac::Get_Name() { return Name; }
Cognac::~Cognac() {}

ostream & operator<<(ostream &out, const Cognac &Q)
{
	out << "Name: " << Q.Name << endl;
	out << "Volume: " << Q.volume << endl;
	out << "Type: " << Q.CType << endl;
	out << "Percent of alcohol: " << Q.percent << endl;
	return out;
}

istream & operator >> (istream &in, Cognac &Q)
{
	int buff = 0;
	in >> Q.volume;
	Q.Set_Volume(Q.volume);
	in >> buff;
	Q.Set_CType(buff);
	return in;
}

