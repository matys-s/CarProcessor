using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProcessor
{
    public class TruckCar : Car
    {
        public int TruckCapacity { get; set; }
        public int TruckAxlePress { get; set; }
        

        public TruckCar() { }

        public TruckCar(string brand, string model, int truckCapacity, int truckAxlePress)
        {
            Brand = brand;
            Model = model;
            TruckCapacity = truckCapacity;
            TruckAxlePress = truckAxlePress;
            CarType = CarType.Truck;
        }
    }


}
