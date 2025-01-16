using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine("*****************************************");

            //double num1 = 2.5;
            //String name = "Ahmad";
            //char ch = 'a';
            //bool bl = false;
            //int num = 2;
            //const int num2 = 3;


            string[] car = { "Toyota", "Honda", "Ford"};

            foreach (string c in car)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine($"Total number of cars: {car.Length}");

        }
    }
}
