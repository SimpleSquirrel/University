#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <math.h>
#include <string>

using namespace std;

struct list
{
	string name;
	struct list *next;
}*BOSH,*PHILIPS, *Bper, *Pper, *SAME, *Psame;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int i, j,k=0;
	int n, n2;
	string bosh, philips;
	cout << "Сколько штуць производит Bosh?" << endl;
	cin >> n;
	BOSH = new(list);
	Bper = BOSH;
	for (i = 0; i < n; i++) 
	{
		cout << "Что производит BOSH" << endl;
		cin >> BOSH->name;
		BOSH->next = new(list);
		BOSH = BOSH->next;
	}

	cout << "Сколько штуць производит Philipls?" << endl;
	cin >> n2;
	PHILIPS = new(list);
	Pper = PHILIPS;
	for (i = 0; i < n2; i++)
	{
		cout << "Что производят PHILIPS" << endl;
		cin >> PHILIPS->name;
		PHILIPS->next = new(list);
		PHILIPS = PHILIPS->next;
	}

	//Вывод
	BOSH = Bper;
	for (i = 0; i < n; i++) 
	{
		cout << BOSH->name << "\t";
		BOSH = BOSH->next;
	}

	PHILIPS = Pper;
	cout << endl;
	for (i = 0; i < n2; i++)
	{
		cout << PHILIPS->name << "\t";
		PHILIPS = PHILIPS->next;
	}
	SAME = new(list);
	Psame = SAME;
	PHILIPS = Pper;
	for (i = 0; i < n2; i++)
	{
		BOSH = Bper;
		for (j = 0; j < n; j++)
		{
			if (PHILIPS->name == BOSH->name)
			{
				SAME->name = BOSH->name;
				SAME->next = new(list);
				SAME = SAME->next;
				k++;
			}
			BOSH = BOSH->next;
		}
		PHILIPS = PHILIPS->next;
	}

	SAME = Psame;
	cout << endl << "Одинаковые элементы:" << endl;
	for (i = 0; i < k; i++)
	{
		cout << SAME->name << "\t";
		SAME = SAME->next;
	}
}