using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {

        static double convert(double km)
        {
          
            double convert = km / 0.6213711922;
            return convert;
        }


        static double hours(double h,double m)
        {
            double hou = h * 60;
            double HM = hou + m;

            return HM;
        }


        static void minutes(int m)
        {

            int h = m / 60;
            int min = m % 60;

            Console.Write(h+" houes ,"+min+" minutes");
        }


        static void compare(int a,int b)
        {
            if (a > b)
                Console.WriteLine("Greater");

            else if (a < b)
                Console.WriteLine("Smaller");

            else
                Console.WriteLine("Equal");

        }

        static void Main(string[] args)
        {
            //1
            //Console.WriteLine("Enter double");
            //double num = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Input: "+num);
            ////int num2  =  Convert.ToInt32(num);
            //Console.WriteLine("output "+ (int)num);



            //2
            //int num = Convert.ToInt32(Console.ReadLine());
            //String num2 = Convert.ToString(num);
            //Console.WriteLine("Your number is: " + num);





            //3
            //String word = Console.ReadLine();
            //String upper = word.ToUpper();
            //String lower = word.ToLower();
            //Console.WriteLine(upper);
            //Console.WriteLine(lower);



            //4
            //String Fname = Console.ReadLine();
            //String Lname = Console.ReadLine();
            //String fullName = Fname + " " + Lname;
            //int len = fullName.Length;
            //Console.WriteLine("Full name "+fullName);
            //Console.WriteLine("Length "+len);




            //5
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 < num2)
            //    Console.WriteLine(num1);
            //else
            //    Console.WriteLine(num2);






            //6
            //Console.WriteLine(convert(Convert.ToDouble(Console.ReadLine())));



            //7
            //Console.WriteLine(hours(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));


            //8
            //minutes(Convert.ToInt32(Console.ReadLine()));


            //9 a
            //compare(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            //9 b


            //int number = Convert.ToInt32(Console.ReadLine());

            //int sum = 0;
            //while (number > 0)
            //{
            //   sum += number % 10;
            //   number /= 10;
            //}

            //Console.WriteLine($"Sum of digits: {sum}");







            //10

            //string input = Console.ReadLine();


            //    int number = Convert.ToInt32(input);
            //    int reversedNumber = 0;


            //    while (number > 0)
            //    {
            //        int remainder = number % 10; 
            //        reversedNumber = reversedNumber * 10 + remainder; 
            //        number /= 10; 
            //    }

            //    Console.WriteLine($"Reversed Number: {reversedNumber}");




            //11

            //Console.Write("Enter the first number: ");
            //string input1 = Console.ReadLine();

            //Console.Write("Enter the second number: ");
            //string input2 = Console.ReadLine();

            //    int number1 = Convert.ToInt32(input1);
            //    int number2 = Convert.ToInt32(input2);

            //    if (number2 != 0) 
            //    {

            //        if (number1 % number2 == 0)
            //        {
            //            Console.WriteLine("Divisible");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Not Divisible");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Division by zero is not allowed.");
            //    }




            //12
            //Console.Write("Enter the first number: ");
            //string input1 = Console.ReadLine();

            //Console.Write("Enter the second number: ");
            //string input2 = Console.ReadLine();

            //Console.Write("Enter the third number: ");
            //string input3 = Console.ReadLine();


            //    int num1 = Convert.ToInt32(input1);
            //    int num2 = Convert.ToInt32(input2);
            //    int num3 = Convert.ToInt32(input3);


            //    int middleValue;

            //    if ((num1 > num2 && num1 < num3) || (num1 > num3 && num1 < num2))
            //    {
            //        middleValue = num1;
            //    }
            //    else if ((num2 > num1 && num2 < num3) || (num2 > num3 && num2 < num1))
            //    {
            //        middleValue = num2;
            //    }
            //    else
            //    {
            //        middleValue = num3;
            //    }


            //    Console.WriteLine($"The middle value is: {middleValue}");

            //    Console.WriteLine($"The middle value is: {middleValue}");


        }
    }
}
