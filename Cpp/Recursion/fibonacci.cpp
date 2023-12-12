#include <bits/stdc++.h>

int fib(int n) {
  if (n <= 1)
    return n;
  return fib(n - 1) + fib(n - 2);
}

int main() {
  std::cout << fib(0) << std::endl;
  std::cout << fib(1) << std::endl;
  std::cout << fib(2) << std::endl;
  std::cout << fib(3) << std::endl;
  std::cout << fib(4) << std::endl;
  std::cout << fib(5) << std::endl;
  std::cout << fib(6) << std::endl;
  std::cout << fib(7) << std::endl;
  std::cout << fib(8) << std::endl;
  std::cout << fib(9) << std::endl;
}