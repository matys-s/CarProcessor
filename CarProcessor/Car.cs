using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProcessor
{
    public abstract class Car 
    {
        public CarType CarType { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        
    }
}
