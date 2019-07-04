using System;

namespace DesignPatterns
{
    /// <summary>
    /// The actual usage of the factory method design pattern
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            CarFactory factory = new ConcreteCarFactory();
            IBuildCar HyundaiCars = factory.ManufactureCar("Hyundai");
            HyundaiCars.BuildCar();

            IBuildCar TataCars = factory.ManufactureCar("Tata");
            TataCars.BuildCar();

            Console.ReadLine();
        }
    }
}
