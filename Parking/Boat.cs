﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Boat : IVehicles
    {
        public string Name { get; set; }
        public bool Besplatno { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public bool IsParked { get; set; }

        public void Parked()
        {
            Console.WriteLine($"Boat with Name:{Name} has parked!");
            IsParked = true;
        }

        public void LeaveParking()
        {
            Console.WriteLine($"Boat with Name:{Name} has left!");
            IsParked = false;
        }
    }
}
