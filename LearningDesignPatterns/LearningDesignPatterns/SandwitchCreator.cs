using System;
using System.Collections.Generic;

namespace LearningDesignPatterns
{
    abstract class Ingredient
    {
    }

    class Bread : Ingredient
    {
    }

    class Chicken : Ingredient
    {

    }

    class Letuce : Ingredient
    {

    }

    class Sauce : Ingredient
    {

    }

    abstract class Sandwich
    {
        public List<Ingredient> _Ingredients = new List<Ingredient>();

        public Sandwich()
        {
            CreateIngredients();
        }

        public abstract void CreateIngredients();

        public List<Ingredient> Ingredients => _Ingredients; 

    }

    class ChickenSandwich : Sandwich
    {
        public override void CreateIngredients()
        {
            Ingredients.Add(new Bread());
            Ingredients.Add(new Chicken());
            Ingredients.Add(new Bread());
            Console.WriteLine("Chicken Sandwich Ready!");
        }
    }

    class SandwichCreator
    {
        public static void Main()
        {
            var chickenSandwich = new ChickenSandwich();
            Console.ReadLine();
        }
    }
}
