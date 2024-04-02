using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage1_0
{
    public class Vehicles
    {
        private string registerNumber; // ska vara unikt 
        private Color color;
        private double weight; 

        public static int instance = 0; 
        List<Vehicles> vehicles = new List<Vehicles>();

        public Color Color
        {
            get { return color; }
            set
            {
                color = value;
            }
        }  
        //ToDo: INclude condition regarding registernumber
        public string RegisterNumber
        {
            get { return registerNumber; } 
            set { registerNumber = value; }
        } 
        public double Weight
        {
            get { return weight; } 
            set { weight = value; }
        } 
        public Vehicles(string registerNumber, Color color, double weight)
        {
            bool loopCondition = true;
            while (loopCondition)
            {
                try
                {
                    RegisterNumber = RegisterNumberExists(registerNumber);
                    loopCondition = false;
                }
                catch (IOException ex)
                {
                    string message = ex.Message;
                    Console.WriteLine(message);
                    Console.WriteLine("Try type in a new register number");
                    registerNumber = Console.ReadLine();
                }
            }
            Color = color; 
            Weight = weight;
            instance++;
        }  
        private string RegisterNumberExists(string aRegisterNumber)
        {
            foreach (Vehicles vehicle in vehicles)
            {
                if (vehicle.RegisterNumber == aRegisterNumber)
                {
                    throw new IOException("Register number already at use, type another one in");
                }
            }
            return aRegisterNumber;
        } 
        public void addVehicles(Vehicles aVehicle)
        {
            vehicles.Add(aVehicle);
        }

        public virtual string ListVehiclesParked()
        {
            return $"Type is: {GetType().Name} \nRegister number: {RegisterNumber}" +
                $"\nColor of car: {this.Color}\nweight: {this.Weight}";
        } 


    }
}
