using System;
using System.Collections.Generic;
using System.Text;
using VehicleDB;

namespace VehicleRepository
{
    class DatabaseManager
    {
        private static readonly VehiclesContext entities;

        // Initialize and open the database connection
        static DatabaseManager()
        {
            entities = new VehiclesContext();
        }

        // Provide an accessor to the database
        public static VehiclesContext Instance
        {
            get
            {
                return entities;
            }
        }
    }
}
