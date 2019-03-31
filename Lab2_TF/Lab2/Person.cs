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
        public static int Count;
        public static int SumOfAllAges;

        public string GetFullName()

        {
            return this.FirstName + " " + this.LastName;
        }
        
        public static double AverageAge()
        {
            return (double)SumOfAllAges / (double)Count;
        }

        public static void AddedPerson(int age)
        {
            Count++;
            SumOfAllAges += age;

        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine("My name is " + this.GetFullName() + ".");
            System.Console.WriteLine("My age is " + this.Age + ".");
            AddedPerson(Age);
        }

        public void PrintSpouseNameAndAge()
        {
            System.Console.WriteLine("My Spouse name is " + this.GetFullName() + ".");
            System.Console.WriteLine("My Spouse age is " + this.Age + ".");
            AddedPerson(Age);
        }

        public static void PrintPersonCountAndAverageAge()
        {
            System.Console.WriteLine(" | Number of People : 4".PadRight(36) + " | ");
            System.Console.WriteLine((" | Average Age      : " + AverageAge().ToString()).PadRight(36) + " | ");
        }
    }
}
