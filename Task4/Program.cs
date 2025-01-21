using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{

    class Student 
    {
        private int StudentID;//field
        private string Name;//field
        private int age;//field
        public const int MinAge = 18; //const
        public const int MaxAge = 40;//const

        public int studentId  //prop set and get
        {  
            get { return this.StudentID; }
            set { this.StudentID = value; }
        }

        public String name //prop set and get
        {
            get { return this.Name; }
            set { this.Name = value; }
        }

        public int Age //prop set and get
        {
            get { return this.age; }
            set 
            { 
                if (value>MinAge && value<MaxAge)
                this.age = value; 

                else
                 Console.WriteLine("Age between 18 - 40");
            }
        }

        public String Email { get; set; } //prop auto


      public Student(String name,int age,int id,String email) //constructor
        {
            this.Name = name;
            this.Age = age;
            this.StudentID = id;
        }

        public void GetDetails() //print
        {
            Console.WriteLine($"{studentId} , {name} , {Age}");
        }


        ~Student() //Destructor
        {
            Console.WriteLine("destroy");
        }


    };


    internal class Program
    {
        static void Main(string[] args)
        {

           
            Student s1=new Student("Ahmad",22,1001,"Email");
            s1.GetDetails();

            Student s2 = new Student("mohammad", 22, 1002, "Email");
            s2.GetDetails();

        }
    }
}



//1.What is a Class ?
//A class is a blueprint or template for creating objects. It defines properties, methods, and behaviors that objects of the class will have.


//2.What is an Object ?
//An object is an instance of a class. It represents a real-world entity and contains data (fields) and functionality (methods) defined by its class.


//3.Difference Between Class and Object
//Class: Blueprint or definition; does not occupy memory.
//Object: Instance of a class; occupies memory and can interact with other objects.


//4. OOP Principles
//Encapsulation: Hiding internal details and providing controlled access.
//Abstraction: Focusing on essential features while hiding complexities.
//Inheritance: Reusing code by deriving one class from another.
//Polymorphism: Allowing methods to have different behaviors based on the object.


//5. What is a Property?
//A property provides controlled access to a class's private fields using get and set.



//6.What is a Field ?
//A field is a variable defined in a class to store data directly.



//7. What is a Constructor?
//A constructor is a special method called automatically when an object is created, used to initialize the object.



//8. What is Encapsulation?
//Encapsulation is the practice of restricting direct access to class fields and providing access through properties or methods to ensure security and integrity.
