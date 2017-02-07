

#include "stdafx.h"
#include <iostream>
#include "cmath"
using namespace std;
int main()
{
	int months, days, years;
	cin >> years;
	cin >> months;
	cin >> days;
	if (months == 1)
	{
		months = 13;
		years--;
	}
	if (months == 2)
	{
		months = 14;
		years--;
	}
	float m = (months * 83) / 32;
	m = m + days;
	m = m + years;
	m = m + years / 4;
	m = m - years / 100;
	m = m + years / 400;
	int remainder = m / 7;
	cout << remainder;
	switch (remainder)
	{
	case 0:
		cout << " -Sunday";
		break;
	case 1:
		cout << " -Monday";
		break;
	case 2:
		cout << " -Tuesday";
		break;
	case 3:
		cout << " -Wednesday";
		break;
	case 4:
		cout << " -Thursday";
		break;
	case 5:
		cout << " -Friday";
		break;
	case 6:
		cout << " -Saturday";
		break;

	default:
		cout << " -WRONG INPUT";
		break;
	}

	return 0;
}

