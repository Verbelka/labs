#include <iostream>
#include <vector>
#include <algorithm>
#include <string>
#include <fstream>
using namespace std;

class Less_Than
{
public:
	bool operator () (const string & s1, const string & s2)
	{ return s1.size() > s2.size(); }
};

int main()
{
	setlocale(LC_ALL, "Russian");
	int count = 0;
	string str;
	vector <string> buff;
	ifstream infile("IN.txt");
	ofstream outfile("OUT.txt");
	if (!infile.is_open())
		cout << "���� �� ����� ���� ������\n" << endl;
	else
	{
		if (infile.peek() == EOF)
			cout << "���� ������ \n" << endl;
	}
	while (getline(infile, str))
	{
		count++;
		if (str.size() >= 100)
		{
			cout << "������ ������ �� ������ ��������� 100 �������� " << endl;
			return 0;
		}
		else
			buff.push_back(str);
	}
	if (count < 30 )
		cout << "���������� ��������� ������� ������ ���� �� ������ 30" << endl;
	else
	{
		stable_sort(buff.begin(), buff.end(), Less_Than());
		for (int i = 0; i < buff.size(); i++)
			outfile << buff[i] << endl;
		outfile << "-----------";
	}
	infile.close();
	outfile.close();
	return 0;
}