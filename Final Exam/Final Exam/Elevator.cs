using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            return
            
        }



    }

}
