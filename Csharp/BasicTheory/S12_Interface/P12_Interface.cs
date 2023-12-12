using System;
namespace ConsoleApp
{
    internal interface IPet // khai báo interface với hai phương thức
    {
        void Feed(); // mô tả phương thức (không có thân)
        void Sound();
    }
    internal interface IBird // khai báo interface với ba phương thức
    {
        void Fly();
        void Sound();
        void Feed();
    }
    internal class Cat : IPet // Cat thực thi IPet
    {
        public Cat() => Console.WriteLine("I'm a cat. ");
        // thực thi cho phương thức Feed và Sound
        // hai phương thức này thực thi theo kiểu implicit
        public void Feed() => Console.WriteLine("Fish, please!");
        public void Sound() => Console.WriteLine("Meow meow!");
    }
    internal class Dog : IPet // Dog thực thi IPet
    {
        public Dog() => Console.WriteLine("I'm a dog. ");
        // cả hai phương thức Feed và Sound thực thi kiểu explicit.
        // Object của Dog không thể gọi hai phương thức này.
        // Hai phương thức này chỉ có thể gọi qua giao diện IPet
        void IPet.Feed() => Console.WriteLine("Bone, please!");
        void IPet.Sound() => Console.WriteLine("Woof woof!");
    }
    internal class Parrot : IPet, IBird // Parrot thực thi cả hai giao diện
    {
        public Parrot() => Console.WriteLine("I'm a parrot. ");
        // hai phương thức này thực thi kiểu implicit, do đó
        // có thể gọi từ object của Parrot
        public void Feed() => Console.WriteLine("Nut, please!");
        public void Fly() => Console.WriteLine("Yeah, I can fly!");
        // hai phương thức này thực thi kiểu explicit, do đó
        // không thể gọi từ object của Parrot 
        // mà chỉ có thể gọi qua giao diện IPet hoặc IBird
        void IPet.Sound() => Console.WriteLine("I can speak!");
        void IBird.Sound() => Console.WriteLine("I can sing, too!");
    }
    internal class BirdLover
    {
        private IBird _bird;
        public BirdLover(IBird bird) => _bird = bird;
        public void Play()
        {
            // _bird có thể gọi đủ các phương thức của IBird
            Console.Write("Fly ...");
            _bird.Fly();
            Console.Write("Say something ...");
            _bird.Sound();
            Console.Write("What do you like to eat? ");
            _bird.Feed();
        }
    }
    internal class PetLover
    {
        private IPet _pet;
        public PetLover(IPet pet) => _pet = pet;
        public PetLover() { }
        public void Play()
        {
            // _pet có thể gọi đủ các phương thức của IPet
            Console.Write("What do you like to eat? ");
            _pet.Feed();
            Console.Write("Now say something ... ");
            _pet.Sound();
        }
    }
    internal class _18_interface
    {
        private static void Main()
        {
            IPet pet = new Dog();
            PetLover petLover = new PetLover(pet);            
            petLover.Play();
            petLover = new PetLover(new Parrot());
            petLover.Play();
            BirdLover birdLover = new BirdLover(new Parrot());
            birdLover.Play();
            Cat cat = new Cat();
            // cat có thể gọi được Feed và Sound
            cat.Feed(); cat.Sound();
            IPet cat2 = new Cat();
            // cat2 có thể gọi Feed và Sound
            cat2.Feed(); cat2.Sound();
            Parrot parrot = new Parrot();
            // (gọi qua object) parrot chỉ gọi được Feed và Fly, không gọi được Sound
            parrot.Feed(); parrot.Fly();
            IBird parrot2 = new Parrot();
            // (gọi qua giao diện) parrot2 gọi được đủ 3 phương thức của IBird 
            parrot2.Feed(); parrot2.Fly(); parrot2.Sound();
            // dog không gọi được phương thức nào (gọi qua object) do
            // cả hai phương thức của Dog đều thực hiện kiểu explicit
            Dog dog = new Dog();
            IPet dog2 = new Dog();
            // gọi qua giao diện: dog2 gọi được cả Feed và Sound
            dog2.Feed(); dog2.Sound();            
            Console.ReadKey();
        }
    }
}