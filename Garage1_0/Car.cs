using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    internal class Car : Vehicles
    {
        private double cylinderVolume;  

        public double CylinderVolume
        {
            get { return cylinderVolume; } 
            set { cylinderVolume = (value < 0) ? 0 : value;}
        }
        public Car(string registerNumber, Color color, double weight, double cylinderVolume) : base(registerNumber, color, weight)
        { 
            CylinderVolume = cylinderVolume;
        }
    }
}
