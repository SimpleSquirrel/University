#include "pch.h"
#include <iostream>
#include <string>
#include <stack>
#include <Windows.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int i, j=0, n;
	int x, y;
	int minlength;
	string text;
	stack<string> STEK;

	cout << "Сколько элементов в стеке?" << endl;
	cin >> n;
	string *Arr = new string[n];
	string *Save = new string[n - 2];

	for (i = 0; i < n; i++)
	{
		cout << "Введите элемент" << endl;
		cin >> text;
		Arr[i] = text;
		STEK.push(text);
	}
	
	for (i = 0; i < n; i++)
	{
		cout << STEK.top() << "\t";
		STEK.pop();
	}
	cout << endl;
	cout << "Введите 2 элемента, которые хотите удалить" << endl;
	cin >> x;
	cin >> y;

	for (i = 0; i < n; i++)
	{
		if (i != x-1 && i != y-1)
		{
			Save[j] = Arr[i];
			j++;
		}
	}

	for (i = 0; i < n-2; i++)
	{
		STEK.push(Save[i]);
	}
	
	minlength = Save[0].length();
	for (i = 1; i < n - 2; i++)
	{
		if (minlength > Save[i].length())
			j = i;
	}

	for (i = 0; i < n - 2; i++)
	{
		cout << STEK.top() << "\t";
		STEK.pop();
	}

	cout << endl << "Строка минимального размера под номером " << j;
}
