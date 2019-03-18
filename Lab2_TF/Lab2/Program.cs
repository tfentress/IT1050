using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person();

            System.Console.WriteLine("Please enter your First Name: ");
            firstPerson.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your Last Name: ");
            firstPerson.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your age: ");
            firstPerson.Age = int.Parse(System.Console.ReadLine());
            firstPerson.Spouse = new Person();


            System.Console.WriteLine("Are you married?     ");
            string isMarriedString = System.Console.ReadLine().ToLower();   // Added for marital status
            bool isMarried = isMarriedString.Contains("y");

            System.Console.WriteLine("What is your Spouse's Name?");
            firstPerson.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your Spouse's Age?");
            firstPerson.Spouse.Age = int.Parse(System.Console.ReadLine());
            firstPerson.Spouse.Spouse = firstPerson;

            Person.SumofAllAges = Person.SumofAllAges + firstPerson.Age;

            firstPerson.PrintNameAndAge();
            firstPerson.Spouse.PrintNameAndAge();

            Person secondPerson = new Person();

            System.Console.WriteLine("Please enter your First Name: ");
            secondPerson.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your Last Name: ");
            secondPerson.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your age: ");
            secondPerson.Age = int.Parse(System.Console.ReadLine());
            secondPerson.Spouse = new Person();


            System.Console.WriteLine("Are you married?     ");
            string isMarriedString2 = System.Console.ReadLine().ToLower();
            bool isMarried2 = isMarriedString.Contains("y");

            System.Console.WriteLine("What is your Spouse's Name?");
            secondPerson.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your Spouse's Age?");
            secondPerson.Spouse.Age = int.Parse(System.Console.ReadLine());
            secondPerson.Spouse.Spouse = secondPerson;

            Person.SumofAllAges = Person.SumofAllAges + secondPerson.Age;

            secondPerson.PrintNameAndAge();
            secondPerson.Spouse.PrintNameAndAge();

            Person.PrintPersonCountAndAverageAge();
            

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();


        }

       
    }
        }
    





        

               

            