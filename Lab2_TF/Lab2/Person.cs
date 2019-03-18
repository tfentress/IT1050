using System;

namespace Lab2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person Spouse;
        public bool isMarried;
        public string isMarriedString;
        public static double SumofAllAges;
        public static int Count { get; private set; }
        public static int SumOfAllAges { get; private set; }

        public static double AverageAge()
        {
            return (double)SumOfAllAges / (double)Count;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

        public static void AllPersonAge(int age)
        {
            Count++;
            SumOfAllAges += age;
        }
        public void PrintNameAndAge()
        {
            System.Console.WriteLine("My name is " + this.GetFullName() + ".");
            System.Console.WriteLine("My age is " + this.Age + ".");

        }

        
        public static void PrintPersonCountAndAverageAge()
        {
            System.Console.WriteLine(" | Number of People : 4".PadRight(36) + " | ");
            System.Console.WriteLine((" | Average Age      : " + AverageAge().ToString()).PadRight(36) + " | ");
        }
    }    
}
