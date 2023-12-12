    using System;
    namespace P01_StructDefinition
    {
        using static Console;    
    /// <summary>
    /// Struct biểu diễn số phức
    /// </summary>
    public struct Complex
    {
        public double Real; // trường thực
        public double Imaginary; // trường ảo
        /// <summary>
        /// Hàm tạo
        /// </summary>
        /// <param name="r">phần thực</param>
        public Complex(double r)
        {
            Real = r;
            Imaginary = 0;
        }
        /// <summary>
        /// Hàm tạo
        /// </summary>
        /// <param name="r">phần thực</param>
        /// <param name="i">phần ảo</param>
        public Complex(double r, double i)
        {
            Real = r;
            Imaginary = i;
        }
        /// <summary>
        /// Chuyển chuỗi hợp lệ thành giá trị của Real và Imaginery
        /// </summary>
        /// <param name="value"></param>
        
        public void Parse(string value)
        {
            var temp = value.Trim();
            if (temp.EndsWith("i") || temp.EndsWith("I"))
            {
                temp = temp.TrimEnd('i', 'I');
                var tokens = temp.Split(new[] { '+', '-' }, 2);
                Real = double.Parse(tokens[0]);
                Imaginary = double.Parse(tokens[1]);
            }
            else
            {
                Real = double.Parse(temp);
            }
        }
        /// <summary>
        /// Chuyển chuỗi hợp lệ thành giá trị của Real và Imaginery
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Complex FromString(string value)
        {
            var temp = new Complex();
            temp.Parse(value);
            return temp;
        }
        /// <summary>
        /// Đặc tính, trả về module của số phức
        /// </summary>
        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);
        /// <summary>
        /// Ghi đè phép toán +
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }
        /// <summary>
        /// Ghi đè phép toán -
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }
        /// <summary>
        /// Ghi đè phương thức ToString() của object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Imaginary == 0)
            {
                return Real.ToString();
            }
            return $"{Real} {(Imaginary > 0 ? '+' : '-')} {Math.Abs(Imaginary)}i";
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            Title = "Complex number";
            // khai báo và khởi tạo biến a thuộc kiểu Complex
            var a = new Complex(1, 2);
            WriteLine($"a = {a}");
            // sử dụng đặc tính Modulus của Complex
            WriteLine($"|a| = {a.Modulus}");
            // gọi phương thức Parse
            a.Parse("10-2i");
            WriteLine($"a = {a}");
            // gọi phương thức tĩnh FromString
            var b = Complex.FromString("5 + 3i");
            WriteLine($"b = {b}");
            // thực hiện phép cộng trên số phức
            WriteLine($"a + b = { a + b}");
            ReadKey();
        }
    }
}