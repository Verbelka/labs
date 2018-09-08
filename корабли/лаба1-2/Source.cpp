#include <iostream>
#include <fstream>
#include <string>
#include <queue>  
#include <vector>
using namespace std;

void Inf(ofstream &outfile, vector <string> &berths)
{
	bool flag = true;
	for (int i = 0; i < berths.size(); ++i)
	{
		if (!berths[i].empty())
			outfile << "�� ������e �����  " << i + 1 << " ����� ������� " << berths[i] << endl;
		else
			flag = false;
	}
	if (!flag)
		outfile << "��������� ������� ��������. " << endl;
}

int main()
{
	ifstream infile("IN.txt");
	ofstream outfile("OUT.txt");
	string str;
	int ch;
	queue <string> myQueue;
	int kolvo;
	int count(0);

	if (!infile.is_open())
		outfile << "���� �� ����� ���� ������\n" << endl;
	else
	{
		if (infile.peek() == EOF)
			outfile << "���� ������ \n" << endl;
		else
		{
			infile >> kolvo;
			vector <string> berths(kolvo);
			
			if (kolvo > 10 || kolvo <= 0)
			{
				outfile << "���������� �������� ������� �������! " << endl;
				return 0;
			}
			
			else
			{
				while (infile.peek() != EOF)
				{
					infile >> ch;
					switch (ch)
					{
					case 1:
						getline(infile, str);

						if (str.empty())
						{
							outfile << "�������� ������� �� ����� ���� ������ �������. " << endl;
							outfile << "-----------" << endl;
							break;
						}

						if (count == kolvo)
						{
							myQueue.push(str);
							outfile << "��������� �������� ���, �������" << str << " ��������� � ������� �� ����. " << endl;
						}
						
						else
						{
							for (int i = 0; i < berths.size(); i++)
							{
								if (berths[i].empty())
								{
									berths[i] = str;
									outfile << "������� " << str << " ���������� �� ������ ����� " << i + 1 << endl;
									count++;
									break;
								}
							}
						}
						
						outfile << "-----------" << endl;
						break;
					case 2:
						int n;
						infile >> n;

						if (n > kolvo || n < 1)
						{
							outfile << "������� � ����� ������� �� ����������!" << endl;
							outfile << "-----------" << endl;
							break;
						}

						if (!berths.at(n - 1).empty())
						{
							outfile << "������ ����� " << n << " �����������. " << endl;
						
							if (myQueue.empty())
							{
								count--;
								berths.at(n - 1).clear();
							}
							
							else
							{
								berths[n - 1] = myQueue.front();
								outfile << "������� " << myQueue.front() << " ���������� �� ������ ����� " << n << endl;
								myQueue.pop();
							}
						}
						else
							outfile << "���� ������ � ��� ��������. " << endl;
						
						outfile << "-----------" << endl;
						break;
					case 3:
						outfile << "���������� �������� � ������� �� ����� : " << myQueue.size() << endl;
						outfile << "-----------" << endl;
						break;
					case 4:
						Inf(outfile, berths);
						outfile << "-----------" << endl;
						break;
					default:
						outfile << "������� ��������� ����������. " << endl;
						outfile << "-----------" << endl;
						break;
					}
					ch = 0;
				}
			}
			outfile.close();
			infile.close();
			return 0;
		}
	}
}