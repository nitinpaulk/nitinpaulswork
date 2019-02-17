using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningDesignPatterns
{
    public interface IBuildCar
    {
        void BuildACar();
    }
    
    internal class HatchBack : IBuildCar
    {
        public void BuildACar()
        {
            Console.WriteLine("Here is the Hatchback");
        }
    }

    internal class SUV : IBuildCar
    {
        public void BuildACar()
        {
            Console.WriteLine("Here is the SUV");
        }
    }

    internal class Sedan : IBuildCar
    {
        public void BuildACar()
        {
            Console.WriteLine("Here is the Sedan");
        }
    }

    public interface IManufacturingPlant
    {
        IBuildCar ManufactureCar();
    }

    public class SedanManufacturingPlant : IManufacturingPlant
    {
        public IBuildCar ManufactureCar()
        {
            Console.WriteLine("Build a sedan");
            return new Sedan();
        }
    }

    class CarManufacturingPlant
    {
        static void Main()
        {
            var Sedan = new SedanManufacturingPlant();
            Sedan.ManufactureCar();
            Console.ReadLine();
        }
    }
}
