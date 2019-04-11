using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parking
{
    public interface IVehicles
    {
        string Make { get; set; }
        string Model { get; set; }
        bool IsParked { get; set; }

        void Parked();
        void LeaveParking();
    }
}
