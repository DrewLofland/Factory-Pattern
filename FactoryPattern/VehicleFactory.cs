using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class VehicleFactory
    {
        public static IVehicle GetVehicle(string userVehicle)
        {
            switch (userVehicle.ToLower())
            {
                case "car":
                    return new Car();
                case "motorcycle":
                case "moto":
                    return new Motorcycle();
                default:
                    return new Car();
            }
        }
    }
}
