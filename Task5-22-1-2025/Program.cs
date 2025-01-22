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
            Console.WriteLine("Vehicle is starting");
        }
    }

    class Car:Vehicle
    {
        public int NumberOfDoors { get; set; }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
        }
    }
}
