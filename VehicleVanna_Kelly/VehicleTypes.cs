namespace VehicleVanna_Kelly
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