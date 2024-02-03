using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            // Polymorphism - Practice
            // with method overriding

            Dog dog = new Dog();
            Cat cat = new Cat();
            Cow cow = new Cow();

            Animal[] animals = { dog, cat, cow };

            foreach(Animal animal in animals)
            {
                animal.Speak();
            }

            Console.ReadKey();
        }
    }

    class Animal
    {
        public virtual void Speak()
        {

        }
    }

    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Dog: Woof");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cat: Meow");
        }
    }

    class Cow : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("Cow: Moo");
        }
    }
}