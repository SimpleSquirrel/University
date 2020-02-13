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
}*FIRST, *SECOND, *Ffirst, *Fsecond;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);

	int i, j;
	int n, n2;
	string text;

	cout << "Сколько элементов в 1 списке" << endl;
	cin >> n;
	FIRST = new(list);
	Ffirst = FIRST;
	cout << "Введите последовательно все элементы" << endl;
	for (i = 0; i < n; i++)
	{
		cin >> FIRST->name;
		FIRST->next = new(list);
		FIRST = FIRST->next;
	}

	cout << "Сколько элементов во 2 списке" << endl;
	cin >> n2;
	SECOND = new(list);
	Fsecond = SECOND;
	cout << "Введите последовательно все элементы" << endl;
	for (i = 0; i < n2; i++)
	{
		cin >> SECOND->name;
		SECOND->next = new(list);
		SECOND = SECOND->next;
	}

	cout << "Введите слово первого списка, после которого будет выводится элементы 2го" << endl;
	cin >> text;

	FIRST = Ffirst;
	SECOND = Fsecond;
	for (i = 0; i < n; i++)
	{
		cout << FIRST->name << endl;
		if (FIRST->name == text)
		{
			cout << "***Начало 2го списка***" << endl;
			for (j = 0; j < n2; j++)
			{
				cout << SECOND->name << endl;
				SECOND = SECOND->next;
			}
			cout << "***Конец 2го списка***" << endl;
		}
		FIRST = FIRST->next;
	}
}