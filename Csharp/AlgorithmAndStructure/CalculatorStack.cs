using System;
using System.Collections.Generic;
using System.Text;
namespace P05_Calculator
{
    class Calculator
    {
        public static int Evaluate(string expression)
        {
            char[] tokens = expression.ToCharArray();
            // stack chứa toán hạng
            Stack<int> operands = new Stack<int>();
            // stack chứa toán tử
            Stack<char> operators = new Stack<char>();

            for (int i = 0; i < tokens.Length; i++)
            {
                // Bỏ qua các bước còn lại nếu gặp ký tự trắng
                if (tokens[i] == ' ')
                {
                    continue;
                }
                // Nếu gặp ký tự chữ số sẽ quét hết các ký tự chữ số tiếp theo,
                // chuyển đổi nó về kiểu int và push vào stack cho toán hạng
                if (tokens[i] >= '0' && tokens[i] <= '9')
                {
                    StringBuilder digitBuffer = new StringBuilder();
                    // quét các ký tự chữ số tiếp theo  
                    while (i < tokens.Length && tokens[i] >= '0' && tokens[i] <= '9')
                    {
                        digitBuffer.Append(tokens[i++]);
                    }
                    operands.Push(int.Parse(digitBuffer.ToString()));
                }
                // Nếu gặp dấu mở ngoặc thì push vào stack toán tử
                else if (tokens[i] == '(')
                {
                    operators.Push(tokens[i]);
                }
                // Nếu gặp dấu đóng ngoặc thì phải giải quyết mớ ở trong ngoặc
                else if (tokens[i] == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        operands.Push(Calculate(operators.Pop(), operands.Pop(), operands.Pop()));
                    }
                    operators.Pop();
                }
                // Nếu gặp ký tự toán tử (+,-,*,/)
                else if (tokens[i] == '+' || tokens[i] == '-' || tokens[i] == '*' || tokens[i] == '/')
                {
                    while (operators.Count > 0 && HasPrecedence(tokens[i], operators.Peek()))
                    {
                        operands.Push(Calculate(operators.Pop(), operands.Pop(), operands.Pop()));
                    }
                    // Push toán tử vào stack dành cho nó
                    operators.Push(tokens[i]);
                }
            }
            // Đã kết thúc giai đoạn phân tích chuỗi
            // Bắt đầu thực hiện phép toán
            while (operators.Count > 0)
            {
                operands.Push(Calculate(operators.Pop(), operands.Pop(), operands.Pop()));
            }
            return operands.Pop();
        }
        // So sánh độ ưu tiên của các phép toán
        public static bool HasPrecedence(char op1, char op2)
        {
            if (op2 == '(' || op2 == ')')
            {
                return false;
            }
            if ((op1 == '*' || op1 == '/') && (op2 == '+' || op2 == '-'))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        // Thực hiện các phép toán cơ bản
        public static int Calculate(char @operator, int b, int a)
        {
            switch (@operator)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    if (b == 0)
                    {
                        throw new NotSupportedException("Cannot divide by zero");
                    }
                    return a / b;
            }
            return 0;
        }
    }
}

// static void Main(string[] args)
        // {
        //     Console.Title = "Custom stack with list";
        //     var stack = new ListStack<string>();
        //     stack.Push("H");
        //     stack.Push("L");
        //     stack.Push("O");
        //     stack.Push("N");
        //     while (!stack.isEmpty)
        //     {
        //         var word = stack.Pop();
        //         Console.Write($"{word}");
        //     }
        //     Console.WriteLine($"\nStack count:{stack.Count}");

        //     Console.Title = "Use stack already have";
        //     /* 
        //         var stack1 = new Stack<string>();
        //         while (stack1.count > 0)
        //         {
        //             var word = stack.Pop();
        //             Console.Write($"{word}");
        //         } 
        //     */
        //     Console.Title = "base converter";  
        // }