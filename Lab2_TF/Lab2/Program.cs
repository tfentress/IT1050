using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Person 1 information

            Person firstPerson = new Person();
            System.Console.WriteLine("Please enter your First Name: ");
            firstPerson.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your Last Name: ");
            firstPerson.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your age: ");
            firstPerson.Age = int.Parse(System.Console.ReadLine());
            firstPerson.Spouse = new Person();

            // Person 1 Martial Status and spouse information

            System.Console.WriteLine("Are you married?     ");
            string isMarriedString = System.Console.ReadLine().ToLower();
            bool isMarried = isMarriedString.Contains("y");
            System.Console.WriteLine("What is your Spouse's Name?");
            firstPerson.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your Spouse's Age?");
            firstPerson.Spouse.Age = int.Parse(System.Console.ReadLine());
            firstPerson.Spouse.Spouse = firstPerson;

            firstPerson.PrintNameAndAge();
            firstPerson.Spouse.PrintSpouseNameAndAge();

            // Person 2 information

            Person secondPerson = new Person();
            System.Console.WriteLine("Please enter your First Name: ");
            secondPerson.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your Last Name: ");
            secondPerson.LastName = System.Console.ReadLine();
            System.Console.WriteLine("Please enter your age: ");
            secondPerson.Age = int.Parse(System.Console.ReadLine());
            secondPerson.Spouse = new Person();

            // Person 2 Martial Status and information

            System.Console.WriteLine("Are you married?     ");
            string isMarriedString2 = System.Console.ReadLine().ToLower();
            bool isMarried2 = isMarriedString.Contains("y");
            System.Console.WriteLine("What is your Spouse's Name?");
            secondPerson.Spouse.FirstName = System.Console.ReadLine();
            System.Console.WriteLine("What is your Spouse's Age?");
            secondPerson.Spouse.Age = int.Parse(System.Console.ReadLine());
            secondPerson.Spouse.Spouse = secondPerson;

           
            secondPerson.PrintNameAndAge();
            secondPerson.Spouse.PrintSpouseNameAndAge();

            Person.PrintPersonCountAndAverageAge();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
           }

        }

       
    }
        
    





        

               

            