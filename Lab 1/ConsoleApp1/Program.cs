
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Declaring VARIABLES 

            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightinches;
            double totalHeightCM;

            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial?");
            middleInitial = System.Console.ReadLine();
            System.Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();
            fullName = firstName + " " + middleInitial + ". " + lastName;

            //Section 2

            System.Console.Write("How tall are you in feet?");
            heightFeet = int.Parse(System.Console.ReadLine());
            System.Console.Write("How many inches do you extend beyond that base height?");
            heightinches = double.Parse(System.Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + (heightinches)) * 2.54;

            //Section 3

            System.Console.Write("Nice to meet you " + fullName + "; what is your age, friend?");
            age = int.Parse(System.Console.ReadLine());
            System.Console.Write("Are you a US citizen?");
            isCitizen = bool.Parse(System.Console.ReadLine());
            isCitizen = true || false;
            canVote = isCitizen && age >= 18;

            System.Console.WriteLine(fullName);
            System.Console.WriteLine(totalHeightCM);
            System.Console.WriteLine(canVote);

            System.Threading.Thread.Sleep(10000);

        }
    }
}
