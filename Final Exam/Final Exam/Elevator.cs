using System;

namespace Final_Exam
{
    class Elevator
    {
        private double MaxWeight;
        Passenger[] Occupants;

        public Elevator(int maxOccupants, double maxWeight)
        {
            Occupants = new Passenger[maxOccupants];
            this.MaxWeight = maxWeight;
        }

        public void AddOccupant(Passenger passenger, int index)
        {
            Occupants[index] = passenger;

        }
        public double GetCurrentWeight()
        {
            double SumOfWeight = 0;
            for (int w = 0; w < Occupants.Length; w++)
            {
                SumOfWeight = Occupants[w].GetWeight() + SumOfWeight;
            }

            return (double)SumOfWeight;
        }

        public bool IsOverMaxCapacity()
        {
            return this.GetCurrentWeight() > this.MaxWeight;
        }

    }

}
