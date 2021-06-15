using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VehicleDB;

namespace VehicleRepository
{
    public class VehicleModel
    {
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public string Color { get; set; }
    }

    public class VehicleRepository
    {
        public VehicleModel Add(VehicleModel vehicleModel)
        {
            var vehicleDb = ToDbModel(vehicleModel);

            DatabaseManager.Instance.Vehicle.Add(vehicleDb);
            DatabaseManager.Instance.SaveChanges();

            vehicleModel = new VehicleModel
            {
                Color = vehicleDb.VehicleColor,
                Id = vehicleDb.VehicleId,
                Make = vehicleDb.VehicleMake,
                Mileage = vehicleDb.VehicleMileage,
                Model = vehicleDb.VehicleModel,
                Year = vehicleDb.VehicleYear
            };
            return vehicleModel;
        }

        public List<VehicleModel> GetAll()
        {
            // Use .Select() to map the database contacts to ContactModel
            var items = DatabaseManager.Instance.Vehicle
              .Select(t => new VehicleModel
              {
                  Color = t.VehicleColor,
                  Id = t.VehicleId,
                  Make = t.VehicleMake,
                  Mileage = t.VehicleMileage,
                  Model = t.VehicleModel,
                  Year = t.VehicleYear,
              }).ToList();

            return items;
        }

        public bool Update(VehicleModel vehicleModel)
        {
            var original = DatabaseManager.Instance.Vehicle.Find(vehicleModel.Id);

            if (original != null)
            {
                DatabaseManager.Instance.Entry(original).CurrentValues.SetValues(ToDbModel(vehicleModel));
                DatabaseManager.Instance.SaveChanges();
                return true;
            }

            return false;
        }

        public bool Remove(int vehicleId)
        {
            var items = DatabaseManager.Instance.Vehicle
                                .Where(t => t.VehicleId == vehicleId);

            if (items.Count() == 0)
            {
                return false;
            }

            DatabaseManager.Instance.Vehicle.Remove(items.First());
            DatabaseManager.Instance.SaveChanges();

            return true;
        }

        private Vehicle ToDbModel(VehicleModel vehicleModel)
        {
            var contactDb = new Vehicle
            {
                VehicleColor = vehicleModel.Color,
                VehicleId = vehicleModel.Id,
                VehicleMake = vehicleModel.Make,
                VehicleMileage = vehicleModel.Mileage,
                VehicleModel = vehicleModel.Model,
                VehicleYear = vehicleModel.Year,
            };

            return contactDb;
        }
    }
}
