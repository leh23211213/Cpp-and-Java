using System;
namespace P01_Inheritance
{
    internal class Bird
    {
        private int _weight;
        public int Weight
        {
            get => _weight;
            set {
                if (value > 0)
                    _weight = value;
            }
        }
        public void Feed() => _weight += 10;
        public Bird() => Console.WriteLine($"Bird created");
        public Bird(int weight)
        {
            _weight = weight;
            Console.WriteLine($"Bird created, {_weight} gr.");
        }
        public void Fly() => Console.WriteLine("Bird is flying");
    }
    internal class Parrot : Bird
    {
        public Parrot() => Console.WriteLine("Parrot created");
        public Parrot(int weight) : base(weight) { }
        public void Speak() => Console.WriteLine("Parrot is speaking");
    }
    internal class Cockatoo : Parrot
    {
        public Cockatoo() => Console.WriteLine("Cockatoo created");
        public void Dance() => Console.WriteLine("Cockatoo is dancing");
    }
    internal class MainClass
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Bird:");
            Bird bird = new Bird(50) { Weight = 100 };
            bird.Feed();
            Console.WriteLine($"Weight: {bird.Weight}");
            bird.Fly();
            Console.WriteLine("rnParrot:");
            Parrot parrot = new Parrot(200);
            parrot.Feed();
            Console.WriteLine($"Weight: {parrot.Weight}");
            parrot.Fly();
            parrot.Speak();
            Console.WriteLine("rnCockatoo:");
            Cockatoo cockatoo = new Cockatoo() { Weight = 300 };
            cockatoo.Feed();
            Console.WriteLine($"Weight: {cockatoo.Weight}");
            cockatoo.Fly();
            cockatoo.Speak();
            cockatoo.Dance();
            Console.ReadKey();
        }
    }
}