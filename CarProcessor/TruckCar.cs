using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProcessor
{
    public class TruckCar : Car
    {
        public double TruckCapacity { get; set; }
        public double TruckAxlePress { get; set; }
        public int NumberOfAxles { get; set; }


        public TruckCar() { }

        public TruckCar(string brand, string model, int truckCapacity, int truckAxlePress, int numberOfAxles)
        {
            Brand = brand;
            Model = model;
            TruckCapacity = truckCapacity;
            TruckAxlePress = truckAxlePress;
            CarType = CarType.Truck;
            NumberOfAxles = numberOfAxles;
        }
    }


}
