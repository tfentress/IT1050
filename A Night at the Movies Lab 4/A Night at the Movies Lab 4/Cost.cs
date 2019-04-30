
namespace A_Night_at_the_Movies_Lab_4
{
    class Cost
    {

        public double TicketOutput;
        public double foodOutput;
        public double totalDiscount;
        public double TotalPrice;
        public double snack;
        public double discount;
        public double Ticket;

       public Cost()
        {

        }
        public double TotalOfAll()
        {
            return this.TotalPrice = (double)TicketOutput + (double)foodOutput - (double)totalDiscount;
            
        }
        public void PrintTotalPrice()
        {
           
        }
        
    }
}
