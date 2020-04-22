using System.Collections.Generic;
using Serilog;

namespace HomeWork_12
{
    public class MotorcycleRepository : IMotorcycle
    {     
        public MotorcycleRepository()
        {
            Log.Debug("Sucsessfuly created a new repository!");
        }

        List<Motorcycle> motorcycles = new List<Motorcycle>();
        
        public void CreateMotorcycle(Motorcycle moto)
        {            
            motorcycles.Add(moto);

            Log.Debug($"Sucseccfuly created new Motorcycle {moto.Name} {moto.Model}");
        }

        public void DeleteMotorcycle(int id)
        {
            Motorcycle item = motorcycles.Find(item => item.Id.Equals(id));

            if (item == null)
            {
                Log.Error("Can't find motorcycle by id!");
            }

            else
            {
                motorcycles.Remove(item);
                Log.Debug("Delete motorcycle!");
            }
        }

        public void GetMotorcycleById(int id)
        {           
            Motorcycle item = motorcycles.Find(item => item.Id.Equals(id));

            if (item == null)
            {
                Log.Error("Can't find motorcycle by id!");
            }

            else
            {
                Log.Debug($"Sucsessfuly finded motorcycle:" +
                      $"ID : {item.Id} " +
                      $"NAME : {item.Name} " +
                      $"MODEL : {item.Model} " +
                      $"YEAR : {item.Year} " +
                      $"ODOMETER : {item.Odometer} ");
            }                 
        }

        public void GetMotorcycles()
        {
            Log.Debug($"All motorcycles in collection:");

            foreach (var item in motorcycles)
            {
                Log.Debug($"ID : {item.Id} " +
                          $"NAME : {item.Name} " +
                          $"MODEL : {item.Model} " +
                          $"YEAR : {item.Year} " +
                          $"ODOMETER : {item.Odometer} ");
            }

            if (motorcycles.Capacity.Equals(0))
            {
                Log.Error($"Collection are empty!");
            }
        }

        public void UpdateMotorcycle(int id, string name, string model, int year, int odometer)
        {
            Motorcycle item = motorcycles.Find(item => item.Id.Equals(id));

            if (item == null)
            {
                Log.Error("Can't find motorcycle by id!");
            }

            item.Name = name;
            item.Model = model;
            item.Odometer = odometer;
            item.Year = year;

            Log.Debug("Sucsessfuly updated information");
            Log.Debug($"New information about motorcycle:" +
                          $"ID : {item.Id} " +
                          $"NAME : {item.Name} " +
                          $"MODEL : {item.Model} " +
                          $"YEAR : {item.Year} " +
                          $"ODOMETER : {item.Odometer} ");
        }
    }
}
