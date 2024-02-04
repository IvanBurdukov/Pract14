using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Pract14
{
    abstract class Animal
    {
        public abstract string Name { get; }

        public Animal()
        {
            // Устанавливаем значение по умолчанию для названия
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine("Животное: " + Name);
            Say();
        }
    }

    class Cat : Animal
    {
        public override string Name => "Кошка";

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        public override string Name => "Собака";

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            cat.ShowInfo();

            Console.WriteLine();

            Animal dog = new Dog();
            dog.ShowInfo();
        }
    }
}