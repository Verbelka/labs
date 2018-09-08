#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Milk::Milk(Names n) :Non_Alcohol(n)
{
	switch (n)
	{
	case Savushkin:
		Name = "Savushkin";
		break;
	case Prostokvashino:
		Name = "Prostokvashino";
		break;
	case Vkusnoe:
		Name = "Vkusnoe";
		break;
	default:
		throw exception("Invalid name.");
		break;
	}
}

Milk::Milk(const Milk &Q) : Non_Alcohol(Q) { fat = Q.fat; }

void Milk::Set_Volume(double new_volume)
{
	if (new_volume <= 0)
		throw exception("Invalid volume. ");
	volume = new_volume;
}

double Milk::Get_Calories()
{ 
	Set_Calories(fat);
	return calories; 
}

void Milk::Set_Calories(double buff)
{
	if (buff >= 0.1 && buff <= 1)
		calories = 35;
	if (buff >= 1.1 && buff <= 2)
		calories = 44;
	if (buff >= 2.1 && buff <= 3.2)
		calories = 59;
	if (buff >= 3.3 && buff <= 5)
		calories = 70;
	if (buff <= 0 || buff >= 5.1)
		throw exception("Invalid fat%.");
	fat = buff;
}

double Milk::Get_Fat() { return fat; }
string Milk::Get_Name() { return Name; }
Milk::~Milk() {}

ostream & operator<<(ostream &out, const Milk &Q)
{
	out << "Name: " << Q.Name << endl;
	out << "Volume: " << Q.volume << endl;
	out << "Fat %: " << Q.fat << endl;
	out << "Calories: " << Q.calories << endl;
	return out;
}

istream & operator >> (istream &in, Milk &Q)
{
	in >> Q.volume;
	Q.Set_Volume(Q.volume);
	in >> Q.fat;
	Q.Set_Calories(Q.fat);
	return in;
}
