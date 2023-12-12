#include <bits/stdc++.h>
using namespace std;
#define size 50
int solveQuadraticEquation(double a, double b, double c);
int checkOnotherCases(int number);
int checkPositiveNegativeAB(int number);
int positiveNumber = 2, negativeNumber = -2;
int main()
{
    system("cls");
    int option, y = 0;
    int a, b, c, delta;
            cout << " Enter a,b,c :  " << endl;
            cin >> a >> b >> c;
            switch (checkPositiveNegativeAB(a))
            {
            case 0:
                if (checkPositiveNegativeAB(b) == positiveNumber)
                {
                    if (checkOnotherCases(c) == 1)
                        cout << " Phuong trinh : " << b << "x+" << c << " = " << y << endl;
                    else if (checkOnotherCases(c) == -1)
                        cout << " Phuong trinh : " << b << "x" << c << " = " << y << endl;
                    else
                        cout << " Phuong trinh : " << b << "x"
                             << " = " << y << endl;
                }
                else
                {
                    switch (checkOnotherCases(b))
                    {
                    case 1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "x"
                                 << " = " << y << endl;
                        break;
                    default:
                        if (c != 0)
                            cout << " Phuong trinh co a = 0 vs b = 0 : ";
                        else
                            cout << " Phuong trinh co a= 0 , b = 0 , c = 0  : ";
                        break;
                    }
                }
                break;
            case 1:
                if (checkPositiveNegativeAB(b) == positiveNumber)
                {
                    if (checkOnotherCases(c) == 1)
                        cout << " Phuong trinh : "
                             << "x^2+" << b << "x+" << c << " = " << y << endl;
                    else if (checkOnotherCases(c) == -1)
                        cout << " Phuong trinh : "
                             << "x^2+" << b << "x" << c << " = " << y << endl;
                    else
                        cout << " Phuong trinh : "
                             << "x^2+" << b << "x"
                             << " = " << y << endl;
                }
                else if (checkPositiveNegativeAB(b) == negativeNumber)
                {
                    if (checkOnotherCases(c) == 1)
                        cout << " Phuong trinh : "
                             << "x^2" << b << "x+" << c << " = " << y << endl;
                    else if (checkOnotherCases(c) == -1)
                        cout << " Phuong trinh : "
                             << "x^2" << b << "x" << c << " = " << y << endl;
                    else
                        cout << " Phuong trinh : "
                             << "x^2" << b << "x"
                             << " = " << y << endl;
                }
                else
                {
                    switch (checkOnotherCases(b))
                    {
                    case 1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << "+x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << "+x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << "+x"
                                 << " = " << y << endl;
                        break;
                    case -1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << "-x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << "-x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << "-x"
                                 << " = " << y << endl;
                        break;

                    default:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "x^2" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "x^2" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "x^2"
                                 << " = " << y << endl;
                        break;
                    }
                }
                break;
            case -1:
                if (checkPositiveNegativeAB(b) == positiveNumber)
                {
                    if (checkOnotherCases(c) == 1)
                        cout << " Phuong trinh : "
                             << "-x^2+" << b << "x+" << c << " = " << y << endl;
                    else if (checkOnotherCases(c) == -1)
                        cout << " Phuong trinh : "
                             << "-x^2+" << b << "x" << c << " = " << y << endl;
                    else
                        cout << " Phuong trinh : "
                             << "-x^2+" << b << "x"
                             << " = " << y << endl;
                }
                else if (checkPositiveNegativeAB(b) == negativeNumber)
                {
                    if (checkOnotherCases(c) == 1)
                        cout << " Phuong trinh : "
                             << "-x^2" << b << "x+" << c << " = " << y << endl;
                    else if (checkOnotherCases(c) == -1)
                        cout << " Phuong trinh : "
                             << "-x^2" << b << "x" << c << " = " << y << endl;
                    else
                        cout << " Phuong trinh : "
                             << "-x^2" << b << "x"
                             << " = " << y << endl;
                }
                else
                {
                    switch (checkOnotherCases(b))
                    {
                    case 1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << "+x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << "+x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << "+x"
                                 << " = " << y << endl;
                        break;
                    case -1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << "-x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << "-x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << "-x"
                                 << " = " << y << endl;
                        break;

                    default:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : "
                                 << "-x^2" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : "
                                 << "-x^2" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : "
                                 << "-x^2"
                                 << " = " << y << endl;
                    }
                }
                break;
                break;
            default:
            {
                if (checkPositiveNegativeAB(b) == positiveNumber)
                {
                    if (checkOnotherCases(b) == 1)
                    {
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : " << a << "x^2+" << b << "x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : " << a << "x^2+" << b << "x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : " << a << "x^2+" << b << "x"
                                 << " = " << y << endl;
                    }
                    else
                    {
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : " << a << "x^2" << b << "x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : " << a << "x^2" << b << "x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : " << a << "x^2" << b << "x"
                                 << " = " << y << endl;
                    }
                }
                else
                {
                    switch (checkOnotherCases(b))
                    {
                    case 1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : " << a << "x^2"
                                 << "+x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : " << a << "x^2"
                                 << "+x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : " << a << "x^2"
                                 << "+x"
                                 << " = " << y << endl;
                        break;
                    case -1:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : " << a << "x^2"
                                 << "-x+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : " << a << "x^2"
                                 << "-x" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : " << a << "x^2"
                                 << "-x"
                                 << " = " << y << endl;
                        break;

                    default:
                        if (checkOnotherCases(c) == 1)
                            cout << " Phuong trinh : " << a << "x^2+" << c << " = " << y << endl;
                        else if (checkOnotherCases(c) == -1)
                            cout << " Phuong trinh : " << a << "x^2" << c << " = " << y << endl;
                        else
                            cout << " Phuong trinh : " << a << "x^2"
                                 << " = " << y << endl;
                        break;
                    }
                }
            }
            break;
            }
            solveQuadraticEquation(a, b, c);
            }

int solveQuadraticEquation(double a, double b, double c)
{
    int delta;
    if (a == 0 && b == 0)
    {
        if (c == 0)
            cout << " PTVSN";
        else
            cout << " PTVN ";
    }
    else if (a == 0)
    {
        cout << "  co 1 nghiem la -c/b = " << fixed << setprecision(2) << -c / b;
    }
    else
    {
        delta = pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            cout << " co 2 nghiem x1 , x2 : " << endl;
            cout << " x1 = " << fixed << setprecision(2) << (-b + sqrt(delta)) / (2 * a) << endl;
            cout << " x2 = " << fixed << setprecision(2) << (-b - sqrt(delta)) / (2 * a);
        }
        else if (delta < 0)
            cout << " PTVN ";
        else
            cout << " phuong trinh co mot nghiem -b/2a : " << fixed << setprecision(2) << -b / (2 * a);
    }
}
int checkOnotherCases(int number)
{
    if (number > 0)
        return 1;
    else if (number < 0)
        return -1;
    return 0;
}
int checkPositiveNegativeAB(int number)
{
    if (number > 0 && number != -1 && number != 1)
        return 2;
    if (number < 0 && number != -1 && number != 1)
        return -2;
    if (number > 0)
        return 1;
    else if (number < 0)
        return -1;
    return 0;
}
