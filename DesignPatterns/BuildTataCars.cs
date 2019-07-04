using System;

namespace DesignPatterns
{
    /// <summary>
    /// Concrete class to implementing the interface to create a concrete product
    /// </summary>
    public class BuildTataCars : IBuildCar
    {
        public void BuildCar()
        {
            Console.WriteLine("Tata cars being built!");
        }
    }
}
