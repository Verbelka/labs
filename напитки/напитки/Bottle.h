#pragma once
#include <iostream>
using namespace std;

enum Names { Carlsberg = 1, Baltica, Lidskoe, Merlo, Bordo, Sotern, Ararat, Shabo, Martell, Savushkin, Prostokvashino, Vkusnoe, Bonaqua, Darida, Minskaya, Sprite, Fanta, Cola};
enum B_types { dark = 1, light, live, non_filtered };
enum W_types { dry = 1, semi_dry, semi_sweet };
enum C_types { old = 1, very_old, special };

class Bottle
{
protected:
	string Name;
	Names name;
	double volume;
public:
	Bottle(Names);
	Bottle(const Bottle &);
	virtual ~Bottle();
	double Get_Volume();
	virtual void Set_Volume(double) = 0;
};

class Alcohol :public Bottle
{
protected:
	double percent;
public:
	Alcohol(Names);
	Alcohol(const Alcohol &);
	virtual double Get_Percent() = 0;
	virtual ~Alcohol();
};

class Non_Alcohol : public Bottle
{
protected:
	double calories;
public:
	Non_Alcohol(Names);
	Non_Alcohol(const Non_Alcohol &);
	virtual double Get_Calories() = 0;
	virtual ~Non_Alcohol();
};


class Beer : public Alcohol
{
private:
	B_types type;
	string BType;
public:
	Beer(Names);
	Beer(const Beer &);
	void Set_Volume(double);
	void Set_Type(int);
	double Get_Percent();
	string Get_Type();
	string Get_Name();
	virtual ~Beer();
	friend ostream &operator << (ostream &, const Beer &);
	friend istream &operator >> (istream &, Beer &);
};


class Wine : public Alcohol
{
private:
	W_types type;
	string WType;
public:
	Wine(Names);
	Wine(const Wine &);
	void Set_Volume(double);
	void Set_WType(int);
	double Get_Percent();
	string Get_Type();
	string Get_Name();
	virtual ~Wine();
	friend ostream &operator << (ostream &, const Wine &);
	friend istream &operator >> (istream &, Wine &);
};


class Cognac : public Alcohol
{
private:
	string CType;
	C_types type;
	int rating;
public:
	Cognac(Names);
	Cognac(const Cognac &);
	void Set_Volume(double);
	void Set_CType(int);
	int Get_Rating(C_types);
	double Get_Percent();
	string Get_Type();
	C_types Get_type();
	string Get_Name();
	virtual ~Cognac();
	friend ostream &operator << (ostream &, const Cognac &);
	friend istream &operator >> (istream &, Cognac &);
};

class Milk : public Non_Alcohol
{
private:
	double fat;
public:
	Milk(Names);
	Milk(const Milk &);
	void Set_Volume(double);
	double Get_Calories();
	double Get_Fat();
	void Set_Calories(double);
	string Get_Name();
	virtual ~Milk();
	friend ostream &operator << (ostream &, const Milk &);
	friend istream &operator >> (istream &, Milk &);
};

class Mineral : public Non_Alcohol
{
private:
	double fizzy;
public:
	Mineral(Names);
	Mineral(const Mineral &);
	void Set_Volume(double);
	double Get_Calories();
	double Get_Fizzy();
	void Set_Fizzy(double);
	string Get_Name();
	virtual ~Mineral();
	friend ostream &operator << (ostream &, const Mineral &);
	friend istream &operator >> (istream &, Mineral &);
};

class Lemonade : public Non_Alcohol
{
private:
	double sweet;
public:
	Lemonade(Names);
	Lemonade(const Lemonade &);
	void Set_Volume(double);
	double Get_Calories();
	double Get_Sweet();
	void Set_Calories(double);
	string Get_Name();
	virtual ~Lemonade();
	friend ostream &operator << (ostream &, const Lemonade &);
	friend istream &operator >> (istream &, Lemonade &);
};