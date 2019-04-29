
namespace A_Night_at_the_Movies_Lab_4
{
    class Cost
    {

        public static double TicketOutput;
        public static double foodOutput;
        public static double totalDiscount;
        public static double TotalPrice;
                

        public double TotalOfAll()
        {
            double totalAmount = TicketOutput + foodOutput - totalDiscount;
            return TotalPrice;
        }
        public void PrintTotalPrice()
        {
            System.Console.WriteLine((" Your Total is: $ " + TotalOfAll()));
            System.Console.WriteLine("Thank you enjoy your movie");
           
        }
        
    }
}
