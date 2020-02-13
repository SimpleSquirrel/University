#include "pch.h"
#include <iostream>
#include <math.h>
#include <Windows.h>

using namespace std;

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	int checker = 1, choose;
	while (checker) 
	{
		cout << "1 - длина и площадь круга" << endl;
		cout << "2 - уравнение" << endl;
		cout << "3 - условие" << endl;
		cout << "4 - выход" << endl;
		cin >> choose;
		switch (choose)
		{
		case 1:
		{
			const double pi = 3.14;
			double sircleLenght, sircleSquare;
			double rad;

			cout << "Введите радиус круга" << endl;
			cin >> rad;
			sircleLenght = 2 * pi*rad;
			sircleSquare = 2 * pow(pi, 2);
			cout << "Длина круга = " << sircleLenght << endl;
			cout << "Площадь круга = " << sircleSquare << endl;


			cout << endl << endl;
			break;
		}
		case 2:
			double x, y;

			cout << "Введите значение х для примера y = tg(sqrt(x))" << endl;
			cin >> x;
			y = tan(sqrt(x));
			cout << "y = " << y << endl;


			cout << endl << endl;
			break;
		case 3:
			int num;
			int arr[4];

			cout << "Проверка истинности \"Сумма двух первых чисел равна сумме двух последних" << endl;
			cout << "Введите четырёхзначное число" << endl;
			cin >> num;
			arr[0] = num / 1000;
			arr[1] = (num / 100) % 10;
			arr[2] = (num / 10) % 100 % 10;
			arr[3] = num % 10;
			if (arr[0] + arr[1] == arr[2] + arr[3])
				cout << "Сумы чисел равны" << endl;
			else
				cout << "Сумы чисел не равны" << endl;
			cout << endl << endl;
			break;
		case 4:
			checker = 0;
			break;
		}
	}
}