using System;
using System.Collections.Generic;

namespace VehicleDB
{
    public partial class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleMake { get; set; }
        public string VehicleModel { get; set; }
        public int VehicleYear { get; set; }
        public int VehicleMileage { get; set; }
        public string VehicleColor { get; set; }
    }
}
