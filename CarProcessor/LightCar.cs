using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProcessor
{
    public class LightCar : Car
    {
        public string EngineCapacity { get; set; }
        public int DoorsNumber { get; set; }
        public int PassengersQuantity { get; set; }

        public LightCar() { }

        public LightCar(string brand, string model, string engineCapacity, int doorsNumber, int passengersQuantity)
        {
            Brand = brand;
            Model = model;
            EngineCapacity = engineCapacity;
            DoorsNumber = doorsNumber;
            PassengersQuantity = passengersQuantity;
            CarType = CarType.LightCar;
        }
    }
}
