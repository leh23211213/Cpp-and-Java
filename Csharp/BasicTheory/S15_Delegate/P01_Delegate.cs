
using System;
namespace ConsoleApp
{
    /* khai báo kiểu delegate MathFunction: 
     * kiểu này có mô tả là (double) -> double
     * nghĩa là có thể gán bất kỳ hàm nào "nhận biến kiểu double,
     * trả về kiểu double" cho biến thuộc kiểu MathFunction
     */
    internal delegate double MathFunction(double x);
    // giả lập việc vẽ đồ thị hàm số
    internal class Graph
    {
        /* khai báo property thuộc kiểu MathFunction.
         * MathFunction được sử dụng như những kiểu dữ liệu thông thường
         */
        public MathFunction Function { get; set; }
        /* phương thức này có 1 tham số đầu vào là kiểu delegate MathFunction.
         * Kiểu delegate làm tham số không khác gì kiểu dữ liệu bình thường
         */
        public void Render(MathFunction function, double[] range)
        {
            // có thể gán biến thuộc kiểu delegate như bình thường
            Function = function;
            // vì function là một object bình thường, nó cũng có những thuộc tính
            // và phương thức như các object khác. Thực tế tất cả kiểu delegate đều
            // kế thừa thừa lớp System.Delegate. Ở đây đang dùng thuộc tính Method 
            // của lớp này.
            Console.WriteLine($"Drawing the function graph: {function.Method}");
            foreach (var x in range)
            {
                // mặc dù function là một object nhưng có thể "gọi" như gọi hàm.
                // đây là sự khác biệt giữa object thuộc kiểu delegate với object
                // tạo ra từ class bình thường
                var y = function(x);
                // ngoài cách gọi này còn còn thể dùng cấu trúc dưới đây
                // var y = function.Invoke(x);
                // 
                // var y = function?.Invoke(x);
                Console.Write($"{y:f3}  ");
            }
            Console.WriteLine("rn-----------------");
        }
    }
    // một lớp thử nghiệm chứa các phương thức có mô tả (double)->double
    internal class Mathematics
    {
        // đây là một instance method
        public double Cos(double x) => Math.Cos(x);
        // đây là một static method
        public static double Tan(double x) => Math.Tan(x);
    }
    internal class Program
    {
        // một static method khác
        private static double Sin(double x)
        {
            return Math.Sin(x);
        }
        private static void Main(string[] args)
        {
            Graph graph = new Graph();
            // khởi tạo vùng giá trị của x
            double[] range = new double[] { 1.0, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9, 2.0 };
            // truyền hàm Sin làm tham số cho Render
            graph.Render(Sin, range);
            // truyền hàm static Tan cho Render
            graph.Render(Mathematics.Tan, range);
            // truyền hàm instance Cos cho Render
            Mathematics math = new Mathematics();
            graph.Render(math.Cos, range);
            // truyền một hàm có sẵn Sqrt của lớp Math trong .net
            graph.Render(Math.Sqrt, range);
            // tạo một hàm vô danh tuân theo mô tả (double) -> double
            // và gán nó cho biến function
            // biến function là biến thuộc kiểu delegate MathFunction
            MathFunction function = delegate (double x) { return x *= 2; };
            // truyền biến function cho hàm Render
            graph.Render(function, range);
            // khai báo và truyền hàm vô danh trực tiếp tại vị trí tham số
            graph.Render(delegate (double x) { return x++; }, range);
            // khai báo và truyền hàm lambda trực tiếp tại vị trí tham số
            graph.Render((double x) => { return x *= 10; }, range);
            // truyền một hàm lambda rút gọn làm tham số
            graph.Render(x => x / 10, range);
            Console.ReadKey();
        }
    }
}