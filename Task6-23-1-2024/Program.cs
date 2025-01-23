using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_23_1_2024
{
    internal class Program
    {
        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }


        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a Shape.");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle.");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Rectangle.");
            }
        }




        abstract class Animal
        { 
            public abstract void MakeSound();

           
            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }
        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows.");
            }
        }


        interface Playable
        {
            void Play();
        }

        class Guitar : Playable
        {
            public void Play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        class Piano : Playable
        {
            public void Play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }

      

        static void Main(string[] args)
        {
            //1
            Calculator calc = new Calculator();
            Console.WriteLine("two integers: " + calc.Add(5, 10));
            Console.WriteLine("three integers: " + calc.Add(1, 2, 3));
            Console.WriteLine("two double: " + calc.Add(5.5, 10.3));

            Console.WriteLine();

            //2
            Shape shape;
            shape = new Circle();
            shape.Draw();
            shape = new Rectangle();
            shape.Draw();


            Console.WriteLine();

            //3
            Animal dog = new Dog();
            Animal cat = new Cat();
            dog.MakeSound();
            dog.Sleep();
            cat.MakeSound();
            cat.Sleep();

            Console.WriteLine();

            //4

            Guitar g = new Guitar();
            g.Play();
            Piano p = new Piano();
            p.Play();


        }
    }
}
