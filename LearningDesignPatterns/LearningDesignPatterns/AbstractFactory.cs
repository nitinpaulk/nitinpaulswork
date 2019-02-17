using System;
using System.Collections.Generic;
using static System.Console;

namespace LearningDesignPatterns
{
    public interface IHotDrink
    {
        void Consume();
    }

    internal class Tea : IHotDrink
    {
        public void Consume()
        {
            WriteLine("This tea is nice");
        }
    }

    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            WriteLine("I prefere black coffee");
            Console.ReadLine();
        }
    }

    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }

    internal class TeaFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"Put tea bag in water. Pour {amount} ml of water and voila!");
            return new Tea();
        }
    }

    public class HotDrinkMachine
    {
        public enum AvailableDrinks
        {
            Coffee,Tea
        }

        private Dictionary<AvailableDrinks, IHotDrinkFactory> factories = new Dictionary<AvailableDrinks, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailableDrinks availabledrink in Enum.GetValues(typeof(AvailableDrinks)))
            {
                var factory = (IHotDrinkFactory) Activator.CreateInstance(
                    Type.GetType("LearningDesignPatterns." + Enum.GetName(typeof(AvailableDrinks), availabledrink) +
                                 "Factory"));
                factories.Add(availabledrink,factory);
            }
        }

        public IHotDrink MakeDrink(AvailableDrinks drink, int amount)
        {
            return factories[drink].Prepare(amount);
        }
    }

    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            WriteLine($"Put coffee power in a cup. Pour {amount} ml of hot water and voila!");
            return new Coffee();
        }
    }

    class AbstractFactory
    {
        static void Main()
        {
            var machine = new HotDrinkMachine();
            var drink = machine.MakeDrink(HotDrinkMachine.AvailableDrinks.Tea, 100);
            drink.Consume();
            ReadLine();
        }
    }
}
