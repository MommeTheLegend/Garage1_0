using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Garage1_0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicles
    {
        private Vehicles[] vehicles;


        public Garage(int size)
        {
            vehicles = new Vehicles[size];
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void NumberofCarsParked(T[] vehicles)
        {
            foreach (T item in vehicles)
            {
                object value = Garage<T>.ListVehiclesParked();
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
