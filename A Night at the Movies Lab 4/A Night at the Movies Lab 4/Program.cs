
namespace A_Night_at_the_Movies_Lab_4
{
    class Program
    {

        static void Main(string[] args)
        {

            System.Console.WriteLine("Hello. Would you like an Evening ticket?    ");
            string inputeveningTicketString = System.Console.ReadLine().ToLower();
            bool inputeveningTickets = inputeveningTicketString.Contains("y") || inputeveningTicketString.Contains("t");
            System.Console.WriteLine("How many tickets for adults:   ");
            int AdultTickets = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many senior tickets:   ");
            int SeniorTickets = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many people under 18:   ");
            int ChildTickets = int.Parse(System.Console.ReadLine());


            System.Console.WriteLine("How many small drinks?   ");
            int smallDrinkTheater = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine(" How many large drinks?   ");
            int LargeDrinkTheater = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many popcorn?   ");
            int PopCorn = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(" How many hotdogs?   ");
            int TheaterHotDog = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(" How many candies?   ");
            int TheaterCandy = int.Parse(System.Console.ReadLine());

            int inputeveningTicket = 0;
            if (inputeveningTicket == 'y')
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
                double TotalEveningTickets = SeniorOutputEvening + ChildOutputEvening + AdultOutputEvening;
            }
            else
            {
                double AdultMatinee = 0;
                double AdultOutputMatinee = 0;
                AdultOutputMatinee += AdultTickets * AdultMatinee;

                double ChildMatinee = 0;
                double ChildOutputMatinee = 0;
                ChildOutputMatinee += ChildTickets * ChildMatinee;

                double SeniorMatinee = 0;
                double SeniorOutputMatinee = 0;
                SeniorOutputMatinee += SeniorTickets * SeniorMatinee;
                double TotalMatineeTickets = SeniorOutputMatinee + ChildOutputMatinee + AdultOutputMatinee;
            }

           
            double SweetPopCorn = 0;
            double PopCornOutput = 0;
            PopCornOutput = PopCorn * SweetPopCorn;

            double HotDog = 0;
            double HotDogOutput = 0;
            HotDogOutput = TheaterHotDog * HotDog;

            double LargeSoda = 0;
            double LargeDrinkOutput = 0;
            LargeDrinkOutput = LargeDrinkTheater * LargeSoda;

            double smallSoda = 0;
            double smallDrinkOutput = 0;
            smallDrinkOutput = smallDrinkTheater * smallSoda;

            int ticketAmount = AdultTickets + ChildTickets + SeniorTickets;

            int PossibleDiscount = System.Math.Min(PopCorn, LargeDrinkTheater);
            double discount1 = System.Math.Min(PossibleDiscount, ticketAmount)* 2;

            double discount2 = 0;
            if (ticketAmount >= 3 && inputeveningTicket == 'y' && PopCorn >= 1)
            {
                discount2 = 4.50;
            }

            double discount3 = 0;
            if (TheaterCandy >= 3)
            {
                discount3 = (TheaterCandy / 4) * 1.99;
            }
            
            
            Cost totalDiscount = new Cost();
            totalDiscount.SumOfDiscounts();

            Cost TotalofAll = new Cost();
            TotalofAll.PrintTotalPrice();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        }
       
        }
    }


