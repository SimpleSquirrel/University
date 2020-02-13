#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <time.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	srand(time(NULL));
	unsigned int i, j;
	int n;
	cout << "Введите размерность массива" << endl;
	cin >> n;

	int *Arr = new int[n];

	int *Arr2 = new int[n];
	int *Povtor = new int[n / 2];

	for (i = 0; i < n; i++)
	{
		Arr[i] = rand() % 20;
		Arr2[i] = rand() % 20;
	}
	for (i = 0; i < n; i++)
		cout << Arr[i] << "\t";
	cout << endl;
	for (i = 0; i < n; i++)
		cout << Arr2[i] << "\t";
	
	cout << endl << endl;
	int counter = 0, min = Arr[i], save;
	for (j = 0; j < n; j++)
	{
		for (i = 0; i < n-1; i++)
		{
			if (Arr[i] < Arr[i + 1])
			{
				save = Arr[i];
				Arr[i] = Arr[i + 1];
				Arr[i + 1] = save;
			}
			if (Arr2[i] < Arr2[i + 1])
			{
				save = Arr2[i];
				Arr2[i] = Arr2[i + 1];
				Arr2[i + 1] = save;
			}
		}
	}
	int k = 0;
	for (i = 0; i < n; i++)
	{
		if (Arr2[i] == Arr2[i + 1]) {
			Povtor[k] = Arr2[i];
			k++;
		}
	}
	for (i = 0; i < k; i++)
	{
		for (j = 0; j < n; j++)
		{
			if (Povtor[i] == Arr[j])
				cout << "Число " << Povtor[i] << " является элементом 1 массива и повторяется во 2м несколько раз" << endl;
		}
	}
	for (i = 0; i < n; i++)
		cout << Arr[i] << "\t";
	
	cout << endl;

	for (i = 0; i < n; i++)
		cout << Arr2[i] << "\t";
	
	
	
}