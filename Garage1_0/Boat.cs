using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    internal class Boat : Vehicles
    {
        private Fueltype fueltype;
        public Fueltype Fueltype
        { 
            get { return fueltype; }
            set
            {
               fueltype = value; 
            }
        } 

        public Boat(string registerNumber, Color color, double weight, Fueltype fueltype) : base(registerNumber, color, weight)
        { 
            Fueltype = fueltype;
        }
    }
}
