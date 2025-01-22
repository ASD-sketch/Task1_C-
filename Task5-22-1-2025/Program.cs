using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_22_1_2025
{
    class Vehicle
    {
        public String Model  { get; set; }
        public String Brand  { get; set; }
         
        public void Start()
        {
            Console.WriteLine($"{Model} , {Brand}");
        }
    }

    class Car:Vehicle
    {
        public int NumberOfDoors { get; set; }
        public void print()
        {
            Console.WriteLine($"{Model} , {Brand} ,{NumberOfDoors}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Brand = "E200";
            car.Model = "Mercedes";
            car.NumberOfDoors = 4;
            car.print();

        }
    }
}
