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
            var poc = new Parking<Car>(90);

            var soc = new Parking<Boat>(12);

            var toc = new Parking<Truck>(15);

            Car golf = new Car
            {
                Make = "Golf",
                Model = "MK 6 GTD"
            };

            Boat agro = new Boat
            {
                Name = "Titanic",
                Besplatno = false
            };

            Truck scania = new Truck
            {
                Make = "Scania",
                Model = "Scania 580"
            };

            poc.ParkVehicles(golf);
            poc.LeaveVehicle(golf);

            Console.WriteLine();

            soc.ParkVehicles(agro);
            soc.LeaveVehicle(agro);

            Console.WriteLine();

            toc.ParkVehicles(scania);
            toc.LeaveVehicle(scania);

            Console.ReadLine();
        }
    }
}
