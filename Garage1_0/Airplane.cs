using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    internal class Airplane : Vehicles
    {
        private int length;
        public int Length
        {
            get { return length; } 
            set { length = value; }
        }
        public Airplane(string registerNumber, Color color, double weight, int length) : base(registerNumber, color, weight)
        { 
            Length = length;
        }
    }
}
