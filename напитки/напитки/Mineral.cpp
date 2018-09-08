#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Mineral::Mineral(Names n) :Non_Alcohol(n)
{
	calories = 0;
	switch (n)
	{
	case Bonaqua:
		Name = "Bonaqua";
		break;
	case Darida:
		Name = "Darida";
		break;
	case Minskaya:
		Name = "Minskaya";
		break;
	default:
		throw exception("Invalid name.");
		break;
	}
}

Mineral::Mineral(const Mineral &Q) : Non_Alcohol(Q) { fizzy = Q.fizzy; }

void Mineral::Set_Volume(double new_volume)
{
	if (new_volume <= 0)
		throw exception("Invalid volume. ");
	volume = new_volume;
}
double Mineral::Get_Calories() { return calories; }
double Mineral::Get_Fizzy() { return fizzy; }

void Mineral::Set_Fizzy(double new_fizzy)
{
	if (new_fizzy < 0 || new_fizzy > 100)
		throw exception("Invalid carbonation.");
	fizzy = new_fizzy;
}

string Mineral::Get_Name() { return Name; }
Mineral::~Mineral() {}

ostream & operator<<(ostream &out, const Mineral &Q)
{
	out << "Name: " << Q.Name << endl;
	out << "Volume: " << Q.volume << endl;
	out << "Fizzy: " << Q.fizzy << "%" << endl;
	out << "Calories: " << Q.calories << endl;
	return out;
}

istream & operator >> (istream &in, Mineral &Q)
{
	in >> Q.volume;
	Q.Set_Volume(Q.volume);
	in >> Q.fizzy;
	Q.Set_Fizzy(Q.fizzy);
	return in;
}