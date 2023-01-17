namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"What type of vehicle do you want? A car or motorcycle?");
            var userVehicle = Console.ReadLine();
            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.Drive();
        }
    }
}
