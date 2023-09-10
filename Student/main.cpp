#include "StudentFuntion.cpp"
#include <iomanip>
#include <iostream>
#include <vector>

int main() {
  int classSize(0);
  inputClassSize(classSize);
  if (classSize != 0) {
    std::vector<Student> student;
    inputStudentInforList(student, classSize);

    std::cout << "Student ID " << std::setw(25) << "Student Name"
              << std::setw(25) << "Year of birth" << std::setw(25)
              << "phone number" << std::setw(25) << "Account" << std::setw(25)
              << "passWord" << std::endl;

    for (const Student &studentList : student) {
      std::cout << std::setw(5) << studentList.getID() << std::setw(30)
                << studentList.getName() << std::setw(22)
                << studentList.getyearOfBirth() << std::setw(25)
                << studentList.getPhoneNumber() << std::setw(30)
                << studentList.getAccount() << std::setw(24)
                << studentList.getPassWord() << std::endl;
    }
    std::cout << "\n DEFAULT STYLE " << std::endl;
    Student studentList1;
    std::cout << std::setw(5) << studentList1.getID() << std::setw(30)
              << studentList1.getName() << std::setw(22)
              << studentList1.getyearOfBirth() << std::setw(22)
              << studentList1.getPhoneNumber() << std::setw(28)
              << studentList1.getAccount() << std::setw(28)
              << studentList1.getPassWord() << std::endl;
  } else {
    system("pause");
  }
}
