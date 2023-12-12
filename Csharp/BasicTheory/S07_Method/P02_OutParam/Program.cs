using System;
namespace P02_OutParam
{
    internal class Program
    {
        /// <summary>
        /// Thực hiện 3 phép toán trong cùng một phương thức
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="sum">tổng (tham số ra)</param>
        /// <param name="product">tích (tham số ra)</param>
        /// <param name="div">thương (tham số ra)</param>
        /// <returns>true nếu b != 0, false nếu b == 0 (không thực hiện được phép chia)</returns>
        private static bool DoMath(int a, int b, out int sum, out int product, out float div)
        {
            sum = a + b;
            product = a * b;
            if (b == 0)
            {
                div = float.NaN;
                return false;
            }
            div = a / b;
            return true;
        }
        private static void Main(string[] args)
        {
            int sum, product;
            float div;
            // người dùng nhập a, b từ bàn phím và biến đổi kiểu thành int
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            // gọi phương thức DoMath, 
            // kết quả hiển thị phụ thuộc giá trị thu được khi gọi phương thức
            bool result = DoMath(a, b, out sum, out product, out div);
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Product = {product}");
            if (result == true)
            {                
                // nếu phép chia không có lỗi thì in kết quả
                Console.WriteLine($"Division = {div}");
            }
            else
            {               
                // nếu phép chia có lỗi thì báo "chia cho 0"
                Console.WriteLine("Division by zero!!!!!!");
            }
            Console.ReadKey();
        }
    }
}