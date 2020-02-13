#include "pch.h"
#include <iostream>
#include <string>
#include <vector>
#include <deque>
#include <list>
#include <set>
#include <map>
#include <algorithm>

using namespace std;
int main()
{
	//VECTOR
	std::vector<int> vect;
	for (int count = 0; count < 5; ++count)
		vect.push_back(10 - count); // вставляем числа в конец массива

	for (int index = 0; index < vect.size(); ++index)
		std::cout << vect[index] << ' ';

	std::cout << '\n';

	//DEQUE
	std::deque<int> deq;
	for (int count = 0; count < 4; ++count)
	{
		deq.push_back(count); // вставляем числа в конец массива
		deq.push_front(10 - count); // вставляем числа в начало массива
	}

	for (int index = 0; index < deq.size(); ++index)
		std::cout << deq[index] << ' ';

	std::cout << '\n';

	//ITERAIOTN VECTOR
	std::vector<int> myVector;
	for (int count = 0; count < 5; ++count)
		myVector.push_back(count);

	std::vector<int>::const_iterator it; // объявляемитератортолькодлячтения
	it = myVector.begin(); // присваиваем ему начало вектора
	while (it != myVector.end()) // пока итератор не достигнет конца
	{
		std::cout << *it << " "; // выводим значение элемента, на который указывает итератор
		++it; // и переходим к следующему элементу
	}

	std::cout << '\n';


	//LIST
	std::list<int> myList;
	for (int count = 0; count < 5; ++count)
		myList.push_back(count);

	std::list<int>::const_iterator it1; // объявляемитератор
	it1 = myList.begin(); // присваиваем ему начало списка
	while (it1 != myList.end()) // пока итератор не достигнет конца
	{
		std::cout << *it1 << " "; // выводим значение элемента, на который указывает итератор
		++it1; // и переходим к следующему элементу
	}

	std::cout << '\n';


	//SET
	std::set<int> mySet;
	mySet.insert(8);
	mySet.insert(3);
	mySet.insert(-4);
	mySet.insert(9);
	mySet.insert(2);

	std::set<int>::const_iterator it2; // объявляемитератор
	it2 = mySet.begin(); // присваиваем ему начало set-а
	while (it2 != mySet.end()) // пока итератор не достигнет конца
	{
		std::cout << *it2 << " "; // выводим значение элемента, на который указывает итератор
		++it2; // и переходим к следующему элементу
	}

	std::cout << '\n';

	//MAP
	std::map<int, std::string> myMap;
	myMap.insert(std::make_pair(3, "cat"));
	myMap.insert(std::make_pair(2, "dog"));
	myMap.insert(std::make_pair(5, "chicken"));
	myMap.insert(std::make_pair(4, "lion"));
	myMap.insert(std::make_pair(1, "spider"));

	std::map<int, std::string>::const_iterator it3; // объявляемитератор
	it3 = myMap.begin(); // присваиваем ему начало вектора
	while (it3 != myMap.end()) // пока итератор не достигнет конца
	{
		std::cout << it3->first << "=" << it3->second << " "; // выводим значение элемента, на который указывает итератор
		++it3; // и переходим к следующему элементу
	}

	std::cout << '\n';


	//MAX MIN
	std::list<int> li;
	for (int nCount = 0; nCount < 5; ++nCount)
		li.push_back(nCount);

	std::list<int>::const_iterator it4; // объявляемитератор
	it4 = min_element(li.begin(), li.end());
	std::cout << *it4 << ' ';
	it4 = max_element(li.begin(), li.end());
	std::cout << *it4 << ' ';

	std::cout << '\n';
}

