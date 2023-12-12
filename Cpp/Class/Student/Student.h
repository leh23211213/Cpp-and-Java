#ifndef Student_h
#define Student_h
#include <string>

class Student {

protected:
  int ID;
  int yearOfBirth;
  std::string name;
  std::string account;
  std::string passWord;
  std::string phoneNumber;

public:
  Student();
  Student(std::string name, int ID, int yearOfBirth, std::string account,
          std::string passWord)
      : name(name), ID(ID), yearOfBirth(yearOfBirth), account(account),
        passWord(passWord) {}
  int getID() const { return ID; }
  int getyearOfBirth() const { return yearOfBirth; }
  std::string getName() const { return name; }
  std::string getAccount() const { return account; }
  std::string getPassWord() const { return passWord; }
  std::string getPhoneNumber() const { return phoneNumber; }
};

#endif