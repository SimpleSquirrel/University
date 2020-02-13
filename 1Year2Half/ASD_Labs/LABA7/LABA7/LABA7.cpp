#include "pch.h"
#include <iostream>
#include <Windows.h>
#include <conio.h>
#include <cmath>

using namespace std;

struct Derevo
{
	int chislo;
	Derevo* left;
	Derevo* right;
};

void Create(int num, Derevo** Tree)
{
	if ((*Tree) == NULL)
	{
		(*Tree) = new Derevo;
		(*Tree)->chislo = num;
		(*Tree)->left = (*Tree)->right = NULL;
		return;
	}

	if (num > (*Tree)->chislo)
		Create(num, &(*Tree)->right);
	else
		Create(num, &(*Tree)->left);
}

void Print(Derevo**Tree, int l)
{
	int i;

	if (*Tree != NULL)
	{
		Print(&((**Tree).right), l + 1);
		for (i = 1; i <= l; i++) cout << "\t";
		cout << (**Tree).chislo << endl;
		Print(&((**Tree).left), l + 1);
	}
}

void Clear(Derevo* Tree)
{
	if (Tree != NULL)
	{
		Clear(Tree->left);
		Clear(Tree->right);
		delete(Tree);
	}
}

void Menu()
{
	Derevo* Tree = NULL;
	int num;
	cout << "Введите последовательно элементы, для выхода ESC" << endl;
	while (_getch() != 'w')
	{
		cin >> num;
		Create(num, &Tree);
	}
	Print(&Tree, 0);
	Clear(Tree);
}

int main()
{
	SetConsoleCP(1251);
	SetConsoleOutputCP(1251);
	Menu();
}