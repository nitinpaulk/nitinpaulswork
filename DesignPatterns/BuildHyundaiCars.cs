using System;

namespace DesignPatterns
{
    /// <summary>
    /// Concrete class to implementing the interface to create a concrete product
    /// </summary>
    public class BuildHyundaiCars : IBuildCar
    {
        public void BuildCar()
        {
            Console.WriteLine("Hyundai cars being built!");
        }
    }
}
