﻿
namespace A_Night_at_the_Movies_Lab_4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            System.Console.WriteLine("Hello. Would you like a Matinee ticket?    ");                    
            string inputTicketString = System.Console.ReadLine().ToLower();
            bool inputTickets = inputTicketString.Contains("y") || inputTicketString.Contains("t");
            System.Console.WriteLine("How many tickets for adults:   ");
            int AdultTickets = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many senior tickets:   ");
            int SeniorTickets = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many people under 18:   ");
            int ChildTickets = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine();
            int inputTicket = 0;

            if (inputTicket == 'y' && AdultTickets >= 1)
            {
               
                double AdultMatinee = 0;
                double AdultOutputMatinee = 0;
                AdultOutputMatinee =  AdultTickets * AdultMatinee;

                System.Console.WriteLine("OK enjoy your movie" + "" + "The concession stand is inside to the right");
            }
             
            if (inputTicket == 'y' && ChildTickets >= 1)
            {
                double ChildMatinee = 0;
                double ChildOutputMatinee = 0;
                ChildOutputMatinee = ChildTickets * ChildMatinee;
                System.Console.WriteLine("OK enjoy your movie" + "" + "The concession stand is inside to the right");
            }

            if (inputTicket == 'y' && SeniorTickets >= 1)
            {
                double SeniorMatinee = 0;
                double SeniorOutputMatinee = 0;
                SeniorOutputMatinee = SeniorTickets * SeniorMatinee;
                System.Console.WriteLine("OK enjoy your movie" + "" + "The concession stand is inside to the right");
            }

            else
            {
                double AdultOutputEvening = 0;
                double AdultEvening = 0;
                AdultOutputEvening = AdultTickets * AdultEvening;

                double ChildEvening = 0;
                double ChildOutputEvening = 0;
                ChildOutputEvening = ChildTickets * ChildEvening;

                double SeniorEvening = 0;
                double SeniorOutputEvening = 0;
                SeniorOutputEvening = SeniorTickets * SeniorEvening;

                System.Console.WriteLine("OK enjoy your movie" + "" + "The concession stand is inside to the right");
            }

            System.Console.WriteLine(" Hello, would you like some popcorn?      ");
            string inputPopCornString = System.Console.ReadLine().ToLower();
            bool inputPopCorns = inputPopCornString.Contains("y") || inputPopCornString.Contains("t");
            int inputPopCorn = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(" How many?   ");
            int PopCorn = int.Parse(System.Console.ReadLine());

            if (inputPopCorn == 'y' && PopCorn >= 1)
            {

                double SweetPopCorn = 0;
                double PopCornOutput = 0;
                PopCornOutput = PopCorn * SweetPopCorn;
            }
            else
            {
                System.Console.WriteLine("We have more selections");
            }

            System.Console.WriteLine(" how about a hotdog?      ");
            string inputHotDogString = System.Console.ReadLine().ToLower();
            bool inputHotDogs = inputHotDogString.Contains("y") || inputHotDogString.Contains("t");
            int inputHotDog = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(" How many?   ");
            int TheaterHotDog = int.Parse(System.Console.ReadLine());

            if (inputHotDog == 'y' && TheaterHotDog >= 1)
            {
                double HotDog = 0;
                double HotDogOutput = 0;
                HotDogOutput = TheaterHotDog * HotDog;
            }

            else
            {
                System.Console.WriteLine("Okay, we still have more to offer");
            }

            System.Console.WriteLine(" what about a drink?      ");
            string inputDrinkString = System.Console.ReadLine().ToLower();
            bool inputDrinkss = inputDrinkString.Contains("y") || inputDrinkString.Contains("t");
            int inputDrink = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(" How many small?   ");
            int smallDrinkTheater = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(" How many large?   ");
            int LargeDrinkTheater = int.Parse(System.Console.ReadLine());
            
            if (inputDrink == 'y' && LargeDrinkTheater >= 1)
            {
                double LargeSoda = 0;
                double LargeDrinkOutput = 0;
                LargeDrinkOutput = LargeDrinkTheater * LargeSoda;
            }
            else if (inputDrink == 'y' && smallDrinkTheater >= 1)
            {
                double smallSoda = 0;
                double smallDrinkOutput = 0;
                smallDrinkOutput = smallDrinkTheater * smallSoda;
            }
           
            else
            {
                System.Console.WriteLine("We have more selections");
            }

            System.Console.WriteLine(" Do you want candy?      ");
            string inputCandyString = System.Console.ReadLine().ToLower();
            bool inputCandyOnly = inputCandyString.Contains("y") || inputCandyString.Contains("t");
            int inputCandy = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(" How many?   ");
            int TheaterCandy = int.Parse(System.Console.ReadLine());

            if (inputCandy == 'y' && TheaterCandy >= 1)
            {
                double OneKindCandy = 0;
                double CandyOutput = 0;
                CandyOutput = TheaterCandy * OneKindCandy;
            }
            else
            {
                System.Console.WriteLine("Thank you and enjoy your movie");
            }



        }
        }
    }

