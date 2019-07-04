using System;

namespace DesignPatterns
{
    /// <summary>
    /// Concrete factory implementing the abstaract class car factory to instantiate the concrete product based on requirement
    /// </summary>
    public class ConcreteCarFactory : CarFactory
    {
        public override IBuildCar ManufactureCar(string BrandName)
        {
            switch(BrandName)
            {
                case "Hyundai":
                    return new BuildHyundaiCars();
                case "Tata":
                    return new BuildTataCars();
                default:
                    throw new ApplicationException("Brand not yet in india");
            }
        }
    }
}
