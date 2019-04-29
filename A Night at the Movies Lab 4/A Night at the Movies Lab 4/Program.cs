
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
            double TicketOutput = 0;

            if (inputeveningTicket == 'y')
            {
                TicketOutput = AdultTickets * 10.99;
                TicketOutput += ChildTickets * 6.99;
                TicketOutput += SeniorTickets * 8.50;
                
            }
            else
            {
                TicketOutput = AdultTickets * 5.99;
                TicketOutput += ChildTickets * 3.99;
                TicketOutput += SeniorTickets * 4.50;                
            }


            double smallSoda = 3.50;
            double LargeSoda = 5.99;
            double HotDog = 3.99;
            double SweetPopCorn = 4.50;
            double OneKindCandy = 1.99;

            double foodOutput = PopCorn * SweetPopCorn;
            foodOutput += TheaterHotDog * HotDog;
            foodOutput += LargeDrinkTheater * LargeSoda;
            foodOutput += smallDrinkTheater * smallSoda;
            foodOutput += TheaterCandy * OneKindCandy;

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

            

            double totalDiscount = discount1 + discount2 + discount3;

            double totalAmount = TicketOutput + foodOutput - totalDiscount;

            System.Console.WriteLine("Tickets : " + TicketOutput + " Snacks : " + foodOutput + " Discounts: " + totalDiscount);

            Cost TotalofAll = new Cost();
            TotalofAll.PrintTotalPrice();

            System.Console.WriteLine("Press any key to continue...");
            System.Console.ReadLine();
        }
       
        }
    }


