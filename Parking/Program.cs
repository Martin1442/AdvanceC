using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Parking poc = new Parking(90);

            Car golf = new Car
            {
                Make = "Golf",
                Model = "MK 6 GTD"
            };

            poc.ParkVehicles(golf);

            poc.LeaveVehicle(golf);
        }

        
    }
}
