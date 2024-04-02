using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    internal class Motorcycle : Vehicles
    {
        private int numberOfEngines;  
        public int NumberOfEngines
        {
            get { return numberOfEngines; } 
            set { numberOfEngines = value; }
        }
        public Motorcycle(string registerNumber, Color color, double weight, int numberOfegines) : base(registerNumber, color, weight)
        { 
            NumberOfEngines = numberOfegines;
        }
    }
}
