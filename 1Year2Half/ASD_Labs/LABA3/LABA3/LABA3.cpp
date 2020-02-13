#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <time.h>
#include <math.h>

using namespace std;

struct TIMETABLE
{
	char priznach[10];
	int num;
	int day,
		mounth;
	int hours,
		minutes;
};

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int n;

	cout << "Введите колово поездов" << endl;
	cin >> n;

	TIMETABLE *Arr = new TIMETABLE[n];

	for (int i = 0; i < n; i++)
	{
		cout << "Введите место назначения, номер поезда, месяц, день, часы, минуты)" << endl;
		cin >> Arr[i].priznach;
		cin >> Arr[i].num;
		cin >> Arr[i].mounth;
		cin >> Arr[i].day;
		if (Arr[i].day > 30)
		{
			Arr[i].mounth += Arr[i].day / 30;
			Arr[i].day %= 30;
		}
		cin >> Arr[i].hours;
		if (Arr[i].hours > 24)
		{
			Arr[i].day += Arr[i].hours / 24;
			Arr[i].hours %= 24;
		}
		cin >> Arr[i].minutes;
		if (Arr[i].minutes > 60)
		{
			Arr[i].hours += Arr[i].minutes / 60;
			Arr[i].minutes %= 60;
		}
	}

	TIMETABLE save;
	for (int j = 0; j < n; j++)
	{
		for (int i = 0; i < n - 1; i++)
		{
			if (Arr[i].mounth < Arr[i + 1].mounth 
				||
				(Arr[i].mounth == Arr[i + 1].mounth && Arr[i].day < Arr[i + 1].day)
				||
				(Arr[i].mounth == Arr[i+1].mounth && Arr[i].day == Arr[i+1].day && Arr[i].hours < Arr[i+1].hours)
				||
				(Arr[i].mounth == Arr[i+1].mounth && Arr[i].day == Arr[i+1].day && Arr[i].hours == Arr[i+1].hours && Arr[i].minutes < Arr[i+1].minutes)
				)
			{
				save = Arr[i];
				Arr[i] = Arr[i + 1];
				Arr[i + 1] = save;
			}
		}
	}

	for (int i = 0; i < n; i++)
	{
		cout << endl << endl;
		cout << "Инфо поезда №" << Arr[i].num << endl;
		cout << "Место назначения: " << *(Arr[i].priznach) << endl;
		cout << "Дата: " << Arr[i].day << "." << Arr[i].mounth << ".2019" << endl;
		cout << "Время: "<< Arr[i].hours << ":" << Arr[i].minutes << ":00"<< endl;
	}
}