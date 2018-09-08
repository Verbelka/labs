#pragma once
#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;

Bottle::Bottle(Names n): name(n) {}
Bottle::Bottle(const Bottle &Q) 
{
	name = Q.name; 
	Name = Q.Name;
	volume = Q.volume;
}
Bottle::~Bottle() {}
double Bottle::Get_Volume() { return volume; }

Alcohol::Alcohol(Names n) : Bottle(n) {}
Alcohol::Alcohol(const Alcohol &Q) : Bottle(Q) {percent = Q.percent; }
Alcohol::~Alcohol() {}

Non_Alcohol::Non_Alcohol(Names n) : Bottle(n) {}
Non_Alcohol::Non_Alcohol(const Non_Alcohol &Q) : Bottle(Q) { calories = Q.calories; }
Non_Alcohol::~Non_Alcohol() {}


