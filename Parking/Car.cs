using System;
namespace Parking
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public bool IsDiesel { get; set; }
        public bool IsElectric { get; set; }

        public bool IsParked { get; set; }
        public Parking Parking { get; set; }

        public void LeaveParking()
        {
            Console.WriteLine($"Car with Make:{Make} and Model:{Model} has left!");
            IsParked = false;
        }
    }
}