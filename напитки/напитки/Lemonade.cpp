#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Lemonade::Lemonade(Names n) :Non_Alcohol(n)
{
	switch (n)
	{
	case Sprite:
		Name = "Sprite";
		break;
	case Fanta:
		Name = "Fanta";
		break;
	case Cola:
		Name = "Coca-cola";
		break;
	default:
		throw exception("Invalid name.");
		break;
	}
}

Lemonade::Lemonade(const Lemonade &Q) : Non_Alcohol(Q) { sweet = Q.sweet; }

void Lemonade::Set_Volume(double new_volume)
{
	if (new_volume <= 0)
		throw exception("Invalid volume. ");
	volume = new_volume;
}

double Lemonade::Get_Calories()
{
	Set_Calories(sweet);
	return calories;
}

double Lemonade::Get_Sweet() { return sweet; }

void Lemonade::Set_Calories(double buff)
{
	if (buff >= 0.1 && buff <= 10)
		calories = 48;
	if (buff >= 10.1 && buff <= 25)
		calories = 56;
	if (buff >= 25.1 && buff <= 50)
		calories = 70;
	if (buff <= 0 || buff > 50)
		throw exception("Invalid sweet%.");
	sweet = buff;
}

string Lemonade::Get_Name() { return Name; }

Lemonade::~Lemonade() {}
ostream & operator<<(ostream &out, const Lemonade &Q)
{
	out << "Name: " << Q.Name << endl;
	out << "Volume: " << Q.volume << endl;
	out << "Sweet: " << Q.sweet << "%" << endl;
	return out;
}

istream & operator >> (istream &in, Lemonade &Q)
{
	in >> Q.volume;
	Q.Set_Volume(Q.volume);
	in >> Q.sweet;
	Q.Set_Calories(Q.sweet);
	return in;
}
