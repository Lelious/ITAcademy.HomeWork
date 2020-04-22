using System;
using Serilog;

namespace HomeWork_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .Enrich.FromLogContext()
                .WriteTo.Console()
                .WriteTo.File("logs\\log.txt", rollingInterval: RollingInterval.Hour)
                .CreateLogger();

            Log.Information($"Starting program {AppDomain.CurrentDomain.FriendlyName}");

            MotorcycleRepository repository = new MotorcycleRepository();            

            repository.CreateMotorcycle(new Motorcycle("Suzuki", "Boulevard C50", 2001, 156487));           
            repository.CreateMotorcycle(new Motorcycle("Suzuki", "Boulevard C90", 2005, 287564));          
            repository.CreateMotorcycle(new Motorcycle("Suzuki", "Boulevard C109R", 2008, 32546));            
            repository.CreateMotorcycle(new Motorcycle("Suzuki", "Boulevard M50", 2002, 79465));           

            repository.GetMotorcycles();

            repository.GetMotorcycleById(2);
            repository.GetMotorcycleById(6); //Error code for check Log error.

            repository.UpdateMotorcycle(3, "Honda", null, 0, 0);

            repository.DeleteMotorcycle(3);

            repository.GetMotorcycles();

            Log.CloseAndFlush();
            Console.ReadKey();
        }
    }
}
