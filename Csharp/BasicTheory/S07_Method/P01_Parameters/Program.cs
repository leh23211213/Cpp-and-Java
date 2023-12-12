using System;
namespace P01_Parameters
{
    internal class Data
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    internal class ParameterPassingTest
    {
        // truyền tham số kiểu value
        public void MethodWithValueType(int a)
        {
            a += 10; // thay đổi giá trị tham số
        }
        // truyền tham số kiểu reference
        public void MethodWithReferenceType(Data s)
        {
            // thay đổi giá trị tham số
            s.Name += " Edited";
            s.Id += 10;
        }
        public void Method2WithReferenceType(Data s)
        {
            // khởi tạo object khác cho s,
            // tương đương với việc cho s tham chiếu sang vùng nhớ khác
            s = new Data { Id = 2, Name = "Donald Trump" };
        }
        // sử dụng từ khóa ref cho kiểu value
        public void Method1WithRefKeyword(ref int a)
        {
            a += 10;
        }
        // sử dụng từ khóa ref cho kiểu reference
        public void Method2WithRefKeyword(ref Data s1, ref Data s2)
        {
            // chỉ đổi giá trị
            s1.Id += 10; s1.Name += " Edited";
            // đổi thành một object khác (thay đổi địa chỉ tham chiếu tới)
            s2 = new Data { Id = 100, Name = "Donald Trump" };
        }
    }
    internal class Program
    {
        private static void Main()
        {
            ParameterPassingTest test = new ParameterPassingTest();
            int a = 0;
            test.MethodWithValueType(a);
            Console.WriteLine(a); // a = 0, không thay đổi, vì a là biến kiểu value
            Data d = new Data { Id = 0, Name = "Hello world" };
            test.MethodWithReferenceType(d);
            // Id = 10, Name = Hello world Edited, giá trị thay đổi vì d thuộc kiểu reference
            Console.WriteLine($"{d.Id}, {d.Name}");
            // phương thức này lại không làm thay đổi d
            // d vấn giữ giá trị Id = 10, Name = Hello world Edited 
            test.Method2WithReferenceType(d);
            Console.WriteLine($"{d.Id}, {d.Name}"); // Id = 10, Name = Hello world Edited
            // như vậy, địa chỉ d trỏ tới không đổi
            test.Method1WithRefKeyword(ref a);
            Console.WriteLine(a); // a = 10, đã thay đổi, vì từ khóa ref
            Data d2 = new Data { Id = 1, Name = "Barrack Obama" }; 
            test.Method2WithRefKeyword(ref d, ref d2);
            // d chỉ thay đổi giá trị, giống trường hợp trên
            Console.WriteLine($"{d.Id}, {d.Name}"); // Id = 10, Name = Hello world Edited
            // d2 trỏ sang object khác
            Console.WriteLine($"{d2.Id}, {d2.Name}"); // Id = 100, Name = Donald Trump
            // như vậy, từ khóa ref cho phép kiểu tham chiếu thay đổi cả địa chỉ vùng nhớ trỏ tới
        }
    }
}