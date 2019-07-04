namespace DesignPatterns
{
    /// <summary>
    /// Abstract class factory returning the interface type to build the concrete product based on the input
    /// </summary>
    public abstract class CarFactory
    {
        public abstract IBuildCar ManufactureCar(string BrandName);
    }
}
