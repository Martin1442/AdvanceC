using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Truck : IVehicles
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public bool IsParked { get; set; }


        public void Parked()
        {
            Console.WriteLine($"Truck with Make:{Make} and Model:{Model} has parked!");
            IsParked = true;
        }
        public void LeaveParking()
        {
            Console.WriteLine($"Truck with Make:{Make} and Model:{Model} has left!");
            IsParked = false;
        }
    }
}
