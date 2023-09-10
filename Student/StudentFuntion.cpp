#include "ConfirmInputData.cpp"
#include "Student.h"
#include <iostream>
#include <vector>

using namespace std;
#define schoolSize 40

void inputClassSize(int &classSize) {
  int templeClassSize = 0;
  int times = 0;
  do {
    cout << "Input Class size: ";
    cin >> templeClassSize;
    if (templeClassSize > 0 && templeClassSize < 10) {
      classSize = templeClassSize;
      break;
    } else {
      times++;
      cout << " Invalid class size, pleas try again." << endl;
    }
    if (times == 3) {
      cout << "!Exceeded the number of entries." << endl;
      break;
    }
  } while (classSize <= 0 || classSize > 10);
}

Student::Student()
    : ID(1000), name("name"), yearOfBirth(0), account("name-ID"),
      passWord("yearOfBirth-ID"), phoneNumber("NONE") {}

string inputName(int pos) {
  string name = "NONE";
  string userInput;
  int times(0);
  do {
    cout << " Enter " << pos << "th student's name: ";
    fflush(stdin);
    getline(cin, userInput);
    if (confirmName(userInput)) {
      return name = userInput;
    } else {
      times++;
      cout << " Invalid name, do not enter any special character in your name."
           << endl
           << " Pleas try again " << endl;
    }
  } while (times != 3);
  return name;
}

int inputYearOfBirth(int pos) {
  string userInput;
  int times(0);
  int yearOfBirth(0);
  int tempYearOfBirth(0);
  do {
    cout << " Enter " << pos << "th student's year of birth(1900-2024): ";
    fflush(stdin);
    getline(cin, userInput);
    if (confirmYearOfBirth(userInput)) {
      tempYearOfBirth = stoi(userInput);
      if (tempYearOfBirth > 1900 && tempYearOfBirth < 2024) {
        return yearOfBirth = tempYearOfBirth;
      } else {
        cout << "! Pleas make sure year of brith in 1900-2024 ranking.\n";
      }
    } else {
      cout << " Invalid year, Pleas try again.\n";
      cout << " ! Do not enter any character.\n";
    }
    times++;
  } while (times != 3);
  return yearOfBirth;
}

void inputStudentInforList(vector<Student> &student, int classSize) {

  for (int i = 1; i <= classSize; i++) {
    int ID = 1000 + i;
    string name = inputName(i);
    int yearOfBirth = inputYearOfBirth(i);
    string account = removeSpace(name + to_string(ID));
    string passWord;
    if (yearOfBirth != 0) {
      passWord = std::to_string(ID) + std::to_string(yearOfBirth);
    } else {
      passWord = "NONE";
    }
    student.push_back(Student(name, ID, yearOfBirth, account, passWord));
  }
}
