using static System.Console;
namespace P03_Params
{
    internal class Math
    {
        public double Sum(params double[] operands)
        {
            var sum = 0.0;
            foreach (var o in operands)
            {
                sum += o;
            }
            return sum;
        }
        public double Product(params double[] operands)
        {
            var product = 1.0;
            foreach (var o in operands)
            {
                product *= o;
            }
            return product;
        }
    }
    class Message
    {
        public string Greeting(params string[] message)
        {
            var greeting = string.Join(" ", message);
            return greeting;
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Title = "params";
            var math = new Math();
            var sum1 = math.Sum(1, 2, 3, 4, 5, 6);
            var sum2 = math.Sum(1, 2, 3);
            var product1 = math.Product(7, 8, 9, 10);
            var product2 = math.Product(4, 5, 6);
            WriteLine($"Sum(1, 2, 3, 4, 5) = {sum1}");
            WriteLine($"Sum(1, 2, 3) = {sum2}");
            WriteLine($"Product(4, 5, 6) = {product2}");
            var msg = new Message();
            var greeting1 = msg.Greeting("Hello", "world", "from", "C#");
            var greeting2 = msg.Greeting("Hi", "this", "is", "params", "method");
            WriteLine(greeting1);
            WriteLine(greeting2);
            ReadKey();
        }
    }
}