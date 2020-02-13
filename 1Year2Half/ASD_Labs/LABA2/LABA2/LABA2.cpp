#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <time.h>
#include <math.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int checker = 1, choose;
	srand(time(NULL));
	while (checker)
	{
		cout << "1 - пункт 1,2" << endl;
		cout << "2 - пункт 3" << endl;
		cout << "3 - пункт 4" << endl;
		cout << "4 - выход" << endl;
		cin >> choose;
		switch (choose)
		{
		case 1:
		{
			int n;
			int flag, sum = 0;
			cout << "Введите колово элементов массива" << endl;
			cin >> n;

			int* Arr = new int[n];
			for (int i = 0; i < n; i++)
				Arr[i] = rand() % 100 - 50;
			int min = Arr[0];

			for (int i = 0; i < n; i++)
			{
				cout << Arr[i] << "\t";
			}
			cout << endl;

			for (int i = 0; i < n; i++)
			{
				if (min >= Arr[i])
				{
					min = Arr[i];
					flag = i;
				}
			}
			int* Save = new int[n];
			int left = 0, right = 1;
			for (int i = 0; i < n; i++)
			{
				if (abs(Arr[i]) < 10)
				{
					Save[left] = Arr[i];
					left++;
				}
				else
				{
					Save[n - right] = Arr[i];
					right++;
				}
			}

			cout << "Минимальный номер " << min << ",его номер " << flag + 1 << endl;
			break;
		}
		case 2:
		{
			int n;
			cout << "Введите размерность массива" << endl;
			cin >> n;
			int* power = new int[n];
			int** Mas = new int*[n];

			for (int i = 0; i < n; i++)
				Mas[i] = new int[n];

			for (int i = 0; i < n; i++)
			{
				power[i] = 0;
				for (int j = 0; j < n; j++)
				{
					Mas[i][j] = rand() % 20 - 10;
					cout << Mas[i][j] << "\t";
				}
				cout << endl;
			}

			int k = 0;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++) {
					if (Mas[j][i] < 0)
						power[i] += abs(Mas[j][i]);
				}

			}


			int save;
			for (int i = 0; i < n - 1; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (power[i] < power[i + 1])
					{	
						save = Mas[j][i];
						Mas[j][i] = Mas[j][i + 1];
						Mas[j][i + 1] = save;
					}
				}
			}
			cout << endl << endl;
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					cout << Mas[i][j] << "\t";
				}
				cout << endl;
			}
		break;
		}
		case 3: 
		{
			int n, k = 1;
			cout << "Введите колово элементов" << endl;
			cin >> n;
			int** mas = new int*[n];

			for (int i = 0; i < n; i++)
				mas[i] = new int[n];

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if (i <=j&& n-i-2<j)
					{
						mas[i][j] = k;
						k++;
					}
					else
						mas[i][j] = 0;
				}
			}
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					cout << mas[i][j] << "\t";
					
				}
				cout << endl<<endl;
			}
		}
			break;
		case 4:
			checker = 0;
			break;
		default:
			cout << "Введите другое число" << endl;
			break;
		}
	}
}