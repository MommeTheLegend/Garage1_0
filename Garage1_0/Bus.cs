using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    internal class Bus : Vehicles
    {
        private int numberOfSeats; 
        public int NumberOfSeat
        {
            get { return numberOfSeats; } 
            set { numberOfSeats = value; }
        }
        public Bus(string registerNumber, Color color, double weight, int numberOfSeats) : base(registerNumber, color, weight)
        {
            NumberOfSeat = numberOfSeats;
        }
    }
}
