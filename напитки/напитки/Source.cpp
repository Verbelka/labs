#include <iostream>
#include <string>
#include "Bottle.h"
using namespace std;
int Menu(Beer &b1, Wine &w1, Cognac &c1, Milk &m1, Mineral &min1, Lemonade &l1)
{
	while (true)
	{
		system("cls");
		int menu;
		cout << "1 - class Beer." << endl;
		cout << "2 - class Wine." << endl;
		cout << "3 - class Cognac." << endl;
		cout << "4 - class Milk." << endl;
		cout << "5 - class Mineral water." << endl;
		cout << "6 - class Lemonade." << endl;
		cout << "0 - exit." << endl;
		cin >> menu;
		switch (menu)
		{
		case 0:	return 0;
		case 1:
			system("cls");
			try
			{
				cout << "Beer " << b1.Get_Name() << endl;
				cout << "\nEnter the volume." << endl;
				cout << "Enter the type of the drink: 1-dark, 2-light, 3-live, 4-non-filtered." << endl;
				cin >> b1;
				cout << "\nInformation: " << endl;
				cout << b1 << endl;;
				cout << "1 - change the volume" << endl;
				cout << "0 - continue." << endl;
				int buff;
				cin >> buff;
				switch (buff)
				{
				case 0:	break;
				case 1:
					system("cls");
					cout << "Enter new volume: " << endl;
					cin >> buff;
					b1.Set_Volume(buff);
					cout << "\n" << b1 << endl;
					break;
				default:
					cout << "Invalid number." << endl;
					break;
				}
			}
			catch (const exception &e)
			{
				cout << e.what() << endl;
			}
			system("pause");
			break;
		case 2:
			system("cls");
			try
			{
				cout << "Wine " << w1.Get_Name() << endl;
				cout << endl;
				cout << "Enter the volume." << endl;
				cout << "Enter the type of the drink: 1-dry, 2-semi-dry, 3-semi-sweet." << endl;
				cin >> w1;
				cout << endl;
				cout << "Information: " << endl;
				cout << w1;
				cout << "\n1 - see the percent of alcohol in your drink." << endl;
				cout << "0 - continue." << endl;
				int buff;
				cin >> buff;
				switch (buff)
				{
				case 0: break;
				case 1:
					system("cls");
					cout << "Percent of alcohol is " << w1.Get_Percent() << "%" << endl;
					break;
				default:
					cout << "Invalid number." << endl;
					break;
				}
			}
			catch (const exception &e)
			{
				cout << e.what() << endl;
			}
			system("pause");
			break;
		case 3:
			system("cls");
			try
			{
				cout << "Cognac " << c1.Get_Name() << endl;
				cout << "\nEnter the volume." << endl;
				cout << "Enter the type of the drink: 1-old, 2-very old, 3-special." << endl;
				cin >> c1;
				cout << "\nInformation: " << endl;
				cout << c1;
				cout << "\n1 - see the rating of your cognac." << endl;
				cout << "0 - continue." << endl;
				int buff;
				cin >> buff;
				switch (buff)
				{
				case 0: break;
				case 1:
					system("cls");
					cout << "Rating is " << c1.Get_Rating(c1.Get_type()) << " stars." << endl;
					break;
				default:
					cout << "Invalid number." << endl;
					break;
				}
			}
			catch (const exception &e)
			{
				cout << e.what() << endl;
			}
			system("pause");
			break;
		case 4:
			system("cls");
			try
			{
				cout << "Milk " << m1.Get_Name() << endl;
				cout << "\nEnter the volume." << endl;
				cout << "Enter the fat%. " << endl;
				cin >> m1;
				cout << "\nInformation: " << endl;
				cout << m1 << endl;;
				cout << "1 - change the fat%. " << endl;
				cout << "0 - continue." << endl;
				int buff;
				cin >> buff;
				switch (buff)
				{
				case 0:	break;
				case 1:
					system("cls");
					cout << "Enter new fat%: " << endl;
					cin >> buff;
					m1.Set_Calories(buff);
					cout << "\n" << m1 << endl;
					break;
				default:
					cout << "Invalid number." << endl;
					break;
				}
			}
			catch (const exception &e)
			{
				cout << e.what() << endl;
			}
			system("pause");
			break;
		case 5:
			system("cls");
			try
			{
				cout << "Mineral water " << min1.Get_Name() << endl;
				cout << "\nEnter the volume." << endl;
				cout << "Enter fizzy. " << endl;
				cin >> min1;
				cout << "\nInformation: " << endl;
				cout << min1 << endl;;
				cout << "1 - change fizzy. " << endl;
				cout << "0 - continue." << endl;
				int buff;
				cin >> buff;
				switch (buff)
				{
				case 0:	break;
				case 1:
					system("cls");
					cout << "Enter new fizzy: " << endl;
					cin >> buff;
					min1.Set_Fizzy(buff);
					cout << "\n" << min1 << endl;
					break;
				default:
					cout << "Invalid number." << endl;
					break;
				}
			}
			catch (const exception &e)
			{
				cout << e.what() << endl;
			}
			system("pause");
			break;
		case 6:
			system("cls");
			try
			{
				cout << "Lemonade " << l1.Get_Name() << endl;
				cout << "\nEnter the volume." << endl;
				cout << "Enter the sweet%. " << endl;
				cin >> l1;
				cout << "\nInformation: " << endl;
				cout << l1 << endl;;
				cout << "1 - calories. " << endl;
				cout << "0 - continue." << endl;
				int buff;
				cin >> buff;
				switch (buff)
				{
				case 0:	break;
				case 1:
					system("cls");
					cout << "Calories: " << l1.Get_Calories() << endl;
					break;
				default:
					cout << "Invalid number." << endl;
					break;
				}
			}
			catch (const exception &e)
			{
				cout << e.what() << endl;
			}
			system("pause");
			break;
		}
	}
}

int main()
{
	try
	{
		Beer b1(Carlsberg);
		Wine w1(Merlo);
		Cognac c1(Ararat);
		Milk m1(Savushkin);
		Mineral min1(Darida);
		Lemonade l1(Fanta);
		Menu(b1, w1, c1, m1, min1, l1);
	}
	catch (const exception &e)
	{
		cout << e.what() << endl;
	}
	return 0;
}
