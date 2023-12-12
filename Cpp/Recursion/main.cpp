#include <bits/stdc++.h>
struct Node {
  int value;
  Node *next;
};
Node *createNode(int value) {
  Node *temp = new Node();
  temp->value = value;
  temp->next = nullptr;
  return temp;
}
void print(Node *list) {
  Node *temp = list;

  while (temp != NULL) {
    std::cout << temp->value << " ";
    temp = temp->next;
  }
}
// **************************************************************************
Node *mergeTwoLists(Node *list1, Node *list2) {
  if (list1 == NULL)
    return list2;
  if (list2 == NULL)
    return list1;

  if (list1->value <= list2->value) {
    Node *next_1 = list1->next;
    Node *newNext = mergeTwoLists(next_1, list2);
    list1->next = newNext;
    return list1;
  } else {
    mergeTwoLists(list2, list1);
    return list2;
  }
}
void _21_mergeTwoListsSolution() {
  Node *a1 = createNode(1);
  Node *a2 = createNode(2);
  Node *a3 = createNode(3);
  a1->next = a2;
  a2->next = a3;
  std::cout << std::endl;
  Node *b1 = createNode(2);
  Node *b2 = createNode(3);
  Node *b3 = createNode(4);
  b1->next = b2;
  b2->next = b3;
  Node *list = mergeTwoLists(a1, b1);
  print(list);
}
// **************************************************************************
Node *reverseList(Node *head) {
  if (head == NULL)
    return head;
  Node *next = head->next;
  Node newNext =  ;
   //return newHead;
}
void _206_reverseList() {

  Node *a1 = createNode(1);
  Node *a2 = createNode(2);
  Node *a3 = createNode(3);
  Node *a4 = createNode(4);
  Node *a5 = createNode(5);
  a1->next = a2;
  a2->next = a3;
  a3->next = a4;
  a4->next = a5;
  // reverseList(a1);
  print(a1);
}
// **************************************************************************
int main() {
  int userRequest = 206;

  switch (userRequest) {
  case 21:
    _21_mergeTwoListsSolution();
    break;
  case 206:
    _206_reverseList();
    break;
  default:
    std::cout << "Unknow command";
    break;
  }
}
