using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public class Parking<T> where T : IVehicles
    {
        public int Capacity { get; set; }
        public int Occupacy { get; set; } 
        public int FreeCapacity { get; set; }

        public List<T> ParkedVehicles { get; set; }

        public Parking(int capacity)
        {
            ParkedVehicles = new List<T>();
            Capacity = capacity;
            FreeCapacity = capacity;
            Occupacy = 0;
        }

        public void ParkVehicles(T vehicle)
        {
            if(FreeCapacity > 0)
            {
                if (!vehicle.IsParked)
                {
                    ParkedVehicles.Add(vehicle);
                    vehicle.Parked();
                    Occupacy += 1;
                    FreeCapacity -= 1;
                    Console.WriteLine($"Spots available {FreeCapacity}");
                }
            }
            
        }
        public void LeaveVehicle(T vehicle)
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
