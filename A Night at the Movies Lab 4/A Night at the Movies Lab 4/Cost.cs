﻿
namespace A_Night_at_the_Movies_Lab_4
{
    class Cost
    {

        int eveningTicket;
        double TotalDiscounts = 0;
        public static double TotalsmallSodaPrice;
        public static double TotalLargeSodaPrice;
        public static double TotalPopCornPrice;
        public static double TotalHotDogPrice;
        public static double TotalCandyPrice;
        public static double TotaleveningPrice;
        public static double TotalmatineePrice;
        //Tickets

        const double AdultMatinee = 5.99;
        const double AdultEvening = 10.99;
        const double SeniorMatinee = 4.50;
        const double SeniorEvening = 8.50;
        const double ChildMatinee = 3.99;
        const double ChildEvening = 6.99;

        //Concession Stand Price List

        const double smallSoda = 3.50;
        const double LargeSoda = 5.99;
        const double HotDog = 3.99;
        const double SweetPopCorn = 4.50;
        const double OneKindCandy = 1.99;

        public double TotalConcessionPrice()
        {
            return TotalsmallSodaPrice + TotalLargeSodaPrice + TotalPopCornPrice + TotalHotDogPrice + TotalCandyPrice;
        }

        public double TotalTicketPrice()
        {
            return TotaleveningPrice + TotalmatineePrice;
        }

        public static void TotalPrice(double Price)
        {

        }
    }
}