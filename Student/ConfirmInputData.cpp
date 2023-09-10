#include <iostream>
#include <string>
using namespace std;
string removeSpace(const string name) {
  string result;
  for (char c : name) {
    if (c != ' ')
      result += c;
  }
  return result;
}
bool confirmName(string userInput) {
  bool check = false;
  string specialCharacter = "!@#$%^&*()_+{}[]|\\:;<>,.?/~1234567890";
  for (char c : userInput) {
    if (check) {
      break;
    }
    for (int i = 0; i < specialCharacter.size(); i++) {
      if (c == specialCharacter[i]) {
        check = true;
        break;
      }
    }
  }
  if (!check)
    return true;
  else
    return false;
}
bool confirmYearOfBirth(string userInput) {
  bool check = false;
  for (int i = 0; i < userInput.size(); i++) {
    if (!std::isdigit(userInput[i])) {
      return false;
    }
  }
  return true;
}
