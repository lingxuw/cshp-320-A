using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace VehicleTracker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static VehicleRepository.VehicleRepository vehicleRepository;

        static App()
        {
            vehicleRepository = new VehicleRepository.VehicleRepository();
        }

        public static VehicleRepository.VehicleRepository VehicleRepository
        {
            get
            {
                return vehicleRepository;
            }
        }
    }
}
