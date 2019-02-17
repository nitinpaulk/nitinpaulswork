using System;

namespace LearningDesignPatterns
{
    class TestCondition
    {
        enum Status
        {
            Active,
            PremiumHoliday,
            Others
        }

        static void Main()
        {
            var value = Status.Active;
            var returnValue = string.Empty;
            if (value != Status.Active || value != Status.PremiumHoliday)
            {
                Console.WriteLine("{0}", value.ToString());
            }

            switch (value)
            {
                case Status.Active:
                case Status.PremiumHoliday:
                    returnValue = value.ToString();
                    break;
                case Status.Others:
                    returnValue = value.ToString();
                    break;
            }

            Console.WriteLine(returnValue);
            Console.ReadLine();
        }
    }
}
