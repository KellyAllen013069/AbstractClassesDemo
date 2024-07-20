using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            var car = new Car()
            {
             Year = 2022,
             Make = "Toyota",
             Model = "Camry",
             HasTrunk = true,
            };
            vehicles.Add(car);

            var motorcycle = new Motorcycle()
            {
             Year = 2019,
             Make = "Harley-Davidson",
             Model = "Sportster",
             HasSideCart = false
            };
            vehicles.Add(motorcycle);
            
            Vehicle vehicle1 = new Car
            {
             Year = 2022,
             Make = "Honda",
             Model = "Civic",
             HasTrunk = true
            };
            vehicles.Add(vehicle1);

            Vehicle vehicle2 = new Motorcycle
            {
             Year = 2020,
             Make = "Yamaha",
             Model = "MT-07",
             HasSideCart = true
            };
            vehicles.Add(vehicle2);
            
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            foreach (var v in vehicles)
            {
             Console.WriteLine($"Year: {v.Year}, Make: {v.Make}, Model: {v.Model}");
             if (v is Car carVehicle)
             {
              Console.WriteLine($"Has Trunk: {carVehicle.HasTrunk}");
             }
             else if (v is Motorcycle motorcycleVehicle)
             {
              Console.WriteLine($"Has Side Cart: {motorcycleVehicle.HasSideCart}");
             }
             Console.WriteLine("---------------------");
            }

            // Call each of the drive methods for one car and one motorcycle
            car.DriveAbstract();
            car.DriveVirtual();
            
            motorcycle.DriveAbstract();
            motorcycle.DriveVirtual();
            #endregion            
        }
    }
}
