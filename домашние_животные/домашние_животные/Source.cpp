#include <iostream>
#include <fstream>
#include <string>
#include <vector>
#include <map>
#include <set>
using namespace std;
typedef vector <pair <string, string>> VPS;
int Menu(VPS Vec, VPS Nick, VPS Age);

void Found(string &str, string &buff)
{
	int count = 0;
	for (int i = 0; i < str.size(); i++)
	{
		count = i;
		if (str[i] == ',')
			break;
	}
	buff = str;
	for (int i = 0; i < str.size() - count + 1; i++)
		buff.erase(buff.begin() + count);
	for (int i = 0; i < count + 1; i++)
		str.erase(str.begin());
}

void Count(VPS Pet)
{
	
	for (int i = 0; i < Pet.size(); i++)
	{
		set <string> buff;
		buff.insert(Pet[i].first);
		int count = 1;
		for (int j = i + 1; j < Pet.size(); j++)
		{
			if (Pet[i].second == Pet[j].second)
			{
				buff.insert(Pet[j].first);
				Pet.erase(Pet.begin() + j);
				j--;
			}
		}
		cout << "Количество различных видов у " << Pet[i].second << ": " << buff.size()<< endl;
	}
}

void Case_2(VPS Vec, string buff)
{
	set <string> buffer;
	set <string>::iterator i;
	for (int i = 0; i < Vec.size(); i++)
	{
		if (buff == Vec[i].first)
		{
			if (Vec[i].second != "")
				buffer.insert(Vec[i].second);
			else
				buffer.insert("Без имени");
		}
	}
	if (buffer.size() == 0)
		cout << "Нет ни у кого. " << endl;
	else
	{
		for (i = buffer.begin(); i != buffer.end(); i++)
			cout << *i << endl;
	}
}

int Case_3(VPS Vec, string buff)
{
	set<string>buffer;
	for (int i = 0; i < Vec.size(); i++)
	{
		if (buff == Vec[i].second)
			buffer.insert(Vec[i].first);
	}
	return buffer.size();
}

void Case_4(VPS Vec)
{
	string min, max;
	int max1 = 0, min1 = 0, vec1 = 0;
	for (int i = 0; i < Vec.size(); i++)
	{
		min = Vec[i].second;
		max = Vec[i].second;
		min1 = atoi(min.c_str());
		max1 = atoi(max.c_str());
		for (int j = i + 1; j < Vec.size(); j++)
		{
			if (Vec[i].first == Vec[j].first)
			{
				vec1 = atoi(Vec[j].second.c_str());
				if (vec1 > max1)
					max1 = vec1;
				if (vec1 < min1)
					min1 = vec1;
				Vec.erase(Vec.begin() + j);
				j--;
			}
		}
		cout << Vec[i].first << " : " << endl;
		cout << "Максимальный возраст : " << max1 << endl;
		cout << "Минимальный возраст : " << min1 << endl;
		cout << endl;
	}
}

int main()
{
	setlocale(LC_ALL, "Russian");
	ifstream infile("input.in");
	if (!infile.is_open())
	{
		cout << "Файл не может быть открыт\n" << endl;
		return 1;
	}
	if (infile.peek() == EOF) 
	{
		cout << "Файл пустой \n" << endl;
		return 1;
	}
	string str, name, type, nick, age;
	VPS Pet;
	VPS Nicks;
	VPS Age;
	while (infile.peek() != EOF)
	{
		infile >> str;
		Found(str, name);
		Found(str, type);
		Found(str, nick);
		age = str;
		for (int i = 0; i < age.size(); i++)
		{
			if (age[i] == 45 || age[0] == 48)
			{
				cerr << "Возраст не может быть отрицательным! " << endl;
				return 1;
			}
		}
		if (name == "" || type == "" || age == "")
		{
			cerr << "Пустую строку вводить нельзя!" << endl;
			return 1;
		}
		Pet.push_back(pair <string, string>(type, name));
		Nicks.push_back(pair <string, string>(type, nick));
		Age.push_back(pair <string, string>(type, age));
	}
	Menu(Pet,Nicks,Age);
	infile.close();
	return 0;
}

int Menu(VPS Vec, VPS Nick, VPS Age)
{
	while (true)
	{
		system("cls");
		int menu;
		string type;
		string nick;
		cout << "Введите: " << endl;
		cout << "1 - количество различных видов животных у каждого владельца. " << endl;
		cout << "2 - узнать всех владельцев и клички определенного вида животного. " << endl;
		cout << "3 - количество видов животных с определенной кличкой. " << endl;
		cout << "4 - информация о возрасте самого старого и самого молодого животного каждого вида. " << endl;
		cout << "0 - выйти. " << endl;
		cin >> menu;
		switch (menu)
		{
		case 0: return 0;
		case 1:
			system("cls");
			Count(Vec);
			system("pause");
			break;
		case 2:
			system("cls");
			cout << "Введите вид животного: " << endl;
			cin >> type;
			system("cls");
			cout << "Владельцы: " << endl;
			Case_2(Vec, type);
			cout << endl;
			cout << "Клички: " << endl;
			Case_2(Nick, type);
			system("pause");
			break;
		case 3:
			system("cls");
			cout << "Введите кличку животного: " << endl;
			cin >> nick;
			system("cls");
			cout << "Количество различных животных с кличкой " << nick << " : " << Case_3(Nick, nick) << endl;
			system("pause");
			break;
		case 4:
			system("cls");
			Case_4(Age);
			system("pause");
			break;
		default:
			system("cls");
			cout << "Введите цифру от 1 до 4! " << endl;
			system("pause");
			break;
		}
	}
}