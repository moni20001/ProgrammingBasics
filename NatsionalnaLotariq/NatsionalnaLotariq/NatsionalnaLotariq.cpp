// NatsionalnaLotariq.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#include <stdlib.h>
using namespace std;
int main(void)
{
	float chislo;
	int work;
	work = 1;
	while (work == 1) {
		system("cls");
		system("Color 0C");
		cout << "////////////////////////////////////////////////////////////////////////////" << endl;
		cout << "/////////////////Dobre doshli v programata za izchislqvane /////////////////" << endl;
		cout<<  "//////////////// Po-golqmo ili Po-malko Suzdadena ot Moni///////////////////" << endl;
		cout << "////////////////////////////////////////////////////////////////////////////" << endl;
		cout << "______________________________________________________________________________" << endl;

		cout << "Vuvedi chislo:";
		cin >> chislo;
		if (chislo < 25 && chislo >= 0) {

			float procent = (chislo / 50) * 100;
			float procent2 = 100 - procent;
			cout << "Po malko:" << procent << "%" << endl;
			cout << "Po golqmo:" << procent2 << "%" << endl;

		}
		if(chislo ==25){
			cout << "Shansovete sa 50% na 50%" << endl;
		}
		if (chislo > 25 && chislo <= 50) {
			
			float procent = chislo * 2;
			float procent2 = 100 - procent;
			cout << "Po malko:" << procent << "%" << endl;
			cout << "Po golqmo:" << procent2 << "%" << endl;
		}
		int produlji;
		cout << "Programata da produlji li?     0=Ne     1= Da" << endl;
		cin >> produlji;
		if (produlji == 0) {
			return work = 0;
		}

	}
	return 0;
}

