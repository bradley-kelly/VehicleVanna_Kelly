using System;
namespace VehicleVanna_Test
{
    class Vehicle
    {
        public enum VehicleTypes
        {
            Car,
            SportsCar,
            Truck,
            Motorcycle,
            MotorHome
        }
        public class Vehicles
        {
            public Vehicles(string make, string model, string year, int listprice, string vehicletype, string firstname, string lastname, string email)
            {
                Make = make;
                Model = model;
                Year = year;
                ListPrice = listprice;
                VehicleType = (VehicleTypes)Enum.Parse(typeof(VehicleTypes), vehicletype);
                FirstName = firstname;
                LastName = lastname;
                Email = email;
            }
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
            public int ListPrice { get; set; }
            public VehicleTypes VehicleType { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
        }
    }
}