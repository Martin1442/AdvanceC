using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parking
    {
        public int Capacity { get; set; }
        public int Occupacy { get; set; } 
        public int FreeCapacity { get; set; }

        public List<Car> ParkedVehicles { get; set; }

        public Parking(int capacity)
        {
            ParkedVehicles = new List<Car>();
            Capacity = capacity;
            FreeCapacity = capacity;
            Occupacy = 0;
        }

        public void ParkVehicles(Car vehicle)
        {
            if (vehicle.IsParked)
            {
                ParkedVehicles.Add(vehicle);
                Console.WriteLine($"Car with Make:{vehicle.Make} and Mode:{vehicle.Model} has parked");
                vehicle.IsParked = true;
                Occupacy += 1;
                FreeCapacity -= 1;
                Console.WriteLine($"Spots available {FreeCapacity}");
            }
        }
        public void LeaveVehicle(Car vehicle)
        {
            if (ParkedVehicles.Contains(vehicle))
            {
                if (vehicle.IsParked)
                {
                    ParkedVehicles.Remove(vehicle);
                    vehicle.LeaveParking();
                    Occupacy -= 1;
                    FreeCapacity += 1;
                    Console.WriteLine($"Spots available {FreeCapacity}");
                }
            }
        }
    }
}
