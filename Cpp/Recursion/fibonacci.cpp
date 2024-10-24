#include <bits/stdc++.h>

int fib(int n) {
  if (n <= 1)
    return n;
  return fib(n - 1) + fib(n - 2);
}

int main() {
  std::cout << fib(9) << std::endl;
}