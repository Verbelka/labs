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
			outfile << "На причалe номер  " << i + 1 << " стоит корабль " << berths[i] << endl;
		else
			flag = false;
	}
	if (!flag)
		outfile << "Остальные причалы свободны. " << endl;
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
		outfile << "Файл не может быть открыт\n" << endl;
	else
	{
		if (infile.peek() == EOF)
			outfile << "Файл пустой \n" << endl;
		else
		{
			infile >> kolvo;
			vector <string> berths(kolvo);
			
			if (kolvo > 10 || kolvo <= 0)
			{
				outfile << "Количество причалов введено неверно! " << endl;
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
							outfile << "Название корабля не может быть пустой строкой. " << endl;
							outfile << "-----------" << endl;
							break;
						}

						if (count == kolvo)
						{
							myQueue.push(str);
							outfile << "Свободных причалов нет, корабль" << str << " отправлен в очередь на рейд. " << endl;
						}
						
						else
						{
							for (int i = 0; i < berths.size(); i++)
							{
								if (berths[i].empty())
								{
									berths[i] = str;
									outfile << "Корабль " << str << " отправился на причал номер " << i + 1 << endl;
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
							outfile << "Причала с таким номером не существует!" << endl;
							outfile << "-----------" << endl;
							break;
						}

						if (!berths.at(n - 1).empty())
						{
							outfile << "Причал номер " << n << " освободился. " << endl;
						
							if (myQueue.empty())
							{
								count--;
								berths.at(n - 1).clear();
							}
							
							else
							{
								berths[n - 1] = myQueue.front();
								outfile << "Корабль " << myQueue.front() << " отправился на причал номер " << n << endl;
								myQueue.pop();
							}
						}
						else
							outfile << "Этот причал и так свободен. " << endl;
						
						outfile << "-----------" << endl;
						break;
					case 3:
						outfile << "Количество кораблей в очереди на рейде : " << myQueue.size() << endl;
						outfile << "-----------" << endl;
						break;
					case 4:
						Inf(outfile, berths);
						outfile << "-----------" << endl;
						break;
					default:
						outfile << "Неверно введенная информация. " << endl;
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