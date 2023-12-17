#include <iostream>
#include <vector>
using namespace std;
int findMaxConsecutiveOnes(vector<int> &number) {
  int count = 0;
  int max = 0;
  for (int i = 0; i < 6; i++) {
    if (number[i] == 0)
      count = 0;
    else {
      count++;
      max = std::max(max, count);
    }
  }
  return max;
}

int main() {
  int arr[10] = {1, 1, 1, 1, 1, 0};
  // cách 1
  // vector<int> a(arr, arr + sizeof(arr) / sizeof(int));

  // cách 2 :
  vector<int> a;
  for (int i = 0; i < (sizeof(arr) / sizeof(int)); i++) {
    a.push_back(arr[i]);
  }

  std::cout << findMaxConsecutiveOnes(a);
}