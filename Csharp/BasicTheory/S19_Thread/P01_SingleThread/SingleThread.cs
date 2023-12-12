namespace SingleThread {
    internal class Program {
        static void Main(string[] args) {
            Task1();
            Task2();
            Task3();
            Console.ReadKey();
        }
        static void Task1() {
            for (int i = 0; i < 5; i++) {
                Console.Write("Task1: {0}  ", i);
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
        static void Task2() {
            for (int i = 0; i < 7; i++) {
                Console.Write("Task2: {0}  ", i);
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
        static void Task3() {
            for (int i = 0; i < 9; i++) {
                Console.Write("Task3: {0}  ", i);
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}