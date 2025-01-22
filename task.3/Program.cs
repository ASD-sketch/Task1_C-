using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task._3
{
    internal class Program
    {
        static String OddEven(int x)
        {
            if (x % 2 == 0)
                return "Even";
            else
                return "Odd";

        }


        static int smallest(int[] arr)
        {
            Array.Sort(arr);
            return arr[1];

        }


        static int fac(int num)
        {


            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }


            return factorial;
        }


        public static void prime()
        {
            int x = 25;
            for (int i = 2; i < x / 2; i++)
            {
                if (x % i == 0)
                {
                    Console.WriteLine("Not Prime");
                    return;
                }

            }
            Console.WriteLine("prime");
        }
      

        static int largest(int[] numbers)
        {

            //int largest = numbers[0];
            
            Array.Sort (numbers);

            int largest = numbers[numbers.Length-2];

            //foreach (int number in numbers)
            //{
            //    if (number > largest)
            //    {
            //        largest = number;
            //    }
            //}

            return largest;
        }



        static void pattern()
        {
            int n = int.Parse(Console.ReadLine()); 

            int number = 1; 

            for (int i = 1; i <= n; i++) 
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{number} ");
                    number++; 
                }
                Console.WriteLine(); 
            }
        }

        class Room
        {
            
            
            
          
            
            public int roomNumber { get; set; }
            public String roomType { get; set; }
            public int pricePerNight { get; set; }
            public bool isBooked { get; set; }

            private static readonly string constantValue = "hotal";
            public static string ConstantProperty
            {
                get { return constantValue; }
            }


            public Room() 
            {
                Console.WriteLine("Constructor");
            }

            public Room(int roomNumber,String roomType,int pricePerNight,bool isBooked)
            {
                this.roomNumber = roomNumber;
                this.roomType = roomType;
                this.pricePerNight = pricePerNight;
                this.isBooked = isBooked;
            }


            ~Room()
            {
                Console.WriteLine("Destructor");
            }



            public void PrintRoomDetails()
            {
                Console.WriteLine($"Hotel: {constantValue}");
                Console.WriteLine($"Room Number: {roomNumber}");
                Console.WriteLine($"Room Type: {roomType}");
                Console.WriteLine($"Price Per Night: ${pricePerNight}");
                Console.WriteLine($"Is Booked: {(isBooked ? "Yes" : "No")}");
                Console.WriteLine();
            }
        }





        static void Main(string[] args)
        {
            // // 1
            //  Console.WriteLine(OddEven(Convert.ToInt32(Console.ReadLine())));


            // // 2
            //  int[] arr = new int[5];
            //  for (int i = 0; i < 5; i++)
            //  {
            //      arr[i] = Convert.ToInt32(Console.ReadLine());
            //  }
            //  Console.WriteLine(smallest(arr));



            ////  3
            //  int num = Convert.ToInt32(Console.ReadLine());
            //  Console.WriteLine(fac(num));





            ////  4
            //  prime();




            // 5
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            { numbers[i] = Convert.ToInt32(Console.ReadLine()); }

            Console.WriteLine(largest(numbers));



            // // 6
            //  pattern();





            // 7



            //Room[] rooms = new Room[2];
            //for (int i = 0; i < rooms.Length; i++)
            //{
            //    rooms[i] = new Room();
            //    Console.WriteLine($"Enter details for Room {i + 1}:");

            //    Console.Write("Enter Room Number: ");
            //    rooms[i].roomNumber = int.Parse(Console.ReadLine());

            //    Console.Write("Single, Double, Suite: ");
            //    rooms[i].roomType = Console.ReadLine();

            //    Console.Write("Enter Price Per Night: ");
            //    rooms[i].pricePerNight = double.Parse(Console.ReadLine());

            //    Console.Write("Is the room booked? (yes/no): ");
            //    string isBookedInput = Console.ReadLine().ToLower();
            //    rooms[i].isBooked = (isBookedInput == "yes");

            //    Console.WriteLine();
            //}

            //Console.WriteLine("Room Details:");
            //foreach (Room room in rooms)
            //{
            //    room.PrintRoomDetails();
            //}


            //Room room = new Room();
            //Room room1 = new Room(1,"single",150,true);
            //room.PrintRoomDetails();
            //room1.PrintRoomDetails();


        }
    }
}
