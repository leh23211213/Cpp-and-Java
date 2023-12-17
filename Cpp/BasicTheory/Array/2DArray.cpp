#include <bits/stdc++.h>
using namespace std;
#define size 50
void input2DArray(int Array[][size], int row, int col);
void output2DArray(int Array[][size], int row, int col);
int calculateMainDiagonalSum(int Array[][size], int row, int col);
int calculateSecondaryDiagonalSum(int Array[][size], int row, int col);
int main()
{
    system("cls");
    int row, col, Array[size][size];
    int option;
    cout << " ___________________MENU ___________________" << endl;
    cout << " 1. IO 2D array    " << endl;
    cout << " 2. Sum of main diagonal: " << endl;
    cout << " 3. Sum of secondary  diagonal: " << endl;
    cout << " Enter '1-3' to continue with menu or press '-1' for out program . " << endl;
    do
    {
        cin >> option;
        if (option == -1)
            break;
        switch (option)
        {
        case 1:
            cout << " Enter row and col : ";
            cin >> row >> col;
            input2DArray(Array, row, col);
            output2DArray(Array, row, col);
            break;
        case 2:
            cout << " Sum of main diagonal : ";
            cout << calculateMainDiagonalSum(Array, row, col);
            break;
        case 3:
            cout << " Sum of secondary diagonal : ";
            calculateSecondaryDiagonalSum(Array, row, col);
            break;
        default:
            cout << " No have in menu  pleas try again .";
            break;
        }
    } while (option);
}
void input2DArray(int Array[][size], int row, int col)
{
    srand(time(NULL));
    for (int i = 0; i < row; i++)
        for (int j = 0; j < col; j++)
        {
            Array[i][j] = rand() % 9 + 1;
        }
}
void output2DArray(int Array[][size], int row, int col)
{
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            cout << Array[i][j] << "  ";
        }
        cout << endl;
    }
}
int calculateMainDiagonalSum(int Array[][size], int row, int col)
{
    int Sum = 0;
    for (int i = 0; i < row; ++i)
        for (int j = 0; j < col; j++)
            if (i == j)
            {
                Sum += Array[i][j];
            }
    return Sum;
}
int calculateSecondaryDiagonalSum(int Array[][size], int row, int col)
{
    int Sum = 0;
    for (int i = row; i <= 0; i--)
        for (int j = 0; j < col; j++)
        {
            Sum += Array[i][j];
        }
    cout << Sum;
}