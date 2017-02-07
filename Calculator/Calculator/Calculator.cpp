// Calculator.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>

using namespace std;
int izchisleniq(void) {
	while (true) {
		cout << "MENU:" << endl;
		cout << "0 - exit" << endl;
		cout << "1 - additional" << endl;
		cout << "2 - subtraction" << endl;
		cout << "3 - multiplication" << endl;
		cout << "4 - division" << endl;
		cout << "Your choice:";
		int izbor;
		cin >> izbor;
		switch (izbor)
		{

		case 0:
			return false;
			break;
		case 1:
			double a, b, sum, sum2;
			cout << "Number:";
			cin >> a;
			cout << "Number:";
			cin >> b;
			sum = a + b;
			cout << "Addition:" << sum << endl;
			break;
		case 2:
			cout << "Number:";
			cin >> a;
			cout << "Number:";
			cin >> b;
			sum = a - b;
			sum2 = b - a;
			cout << "Substaction: " << sum << " And:" << sum2 << endl;
			break;
		case 3:
			cout << "Number:";
			cin >> a;
			cout << "Number:";
			cin >> b;
			sum = a * b;
			cout << "Multiplication:" << sum << endl;
			break;
		case 4:
			cout << "Number:";
			cin >> a;
			cout << "Number:";
			cin >> b;
			sum = a / b;
			sum2 = b / a;
			cout << "Division: " << sum << " And: " << sum2 << endl;
			break;
		default:
			cout << "wrong input";
			break;
		}
		cout << "Do you want to repeat?(0-no/1-yes):";
		int repeat;
		cin >> repeat;
		system("cls");
		if (repeat == 0) {
			return false;
		}
	}
}
int main(void)
{
	cout << "/////////////////////////////////////////////////////////////////////////////" << endl;
	cout << "//////////////////////////////////CALCULATOR/////////////////////////////////" << endl;
	cout << "//////////////////////////////Suzdaden ot Moni///////////////////////////////" << endl;
	cout << "/////////////////////////////////////////////////////////////////////////////" << endl;
	cout << "______________________________________________________________________________" << endl;
	izchisleniq();
    return 0;

}

