using System;
using System.Linq;

namespace ExtensionMethodExample
{
    //завдання 1
    //public static class ArrayExtensions
    //{
    //    public static int[] Filter(this int[] array, Func<int, bool> predicate)
    //    {
    //        int[] filteredArray = new int[array.Length];
    //        int index = 0;
    //        for (int i = 0; i < array.Length; i++)
    //        {
    //            if (predicate(array[i]))
    //            {
    //                filteredArray[index] = array[i];
    //                index++;
    //            }
    //        }
    //        Array.Resize(ref filteredArray, index);
    //        return filteredArray;
    //    }
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        int[] numbers = { 1, 2, 3, 4, 5, 6 };
    //        int[] evenNumbers = numbers.Filter(x => x % 2 == 0);
    //        int[] oddNumbers = numbers.Filter(x => x % 2 != 0);

    //        Console.WriteLine("Even numbers:");
    //        foreach (int number in evenNumbers)
    //        {
    //            Console.WriteLine(number);
    //        }

    //        Console.WriteLine("Odd numbers:");
    //        foreach (int number in oddNumbers)
    //        {
    //            Console.WriteLine(number);
    //        }
    //    }
    //}




    //завдання 2
    class DailyTemperature
    {
        public DateTime Date { get; set; }
        public double Highest_Temperature { get; set; }
        public double Lowest_Temperature { get; set; }
        public double[] Temperatures { get; set; }

        public DailyTemperature(DateTime date, double highestTemperature, double lowestTemperature, double[] temperatures)
        {
            Date = date;
            Highest_Temperature = highestTemperature;
            Lowest_Temperature = lowestTemperature;
            Temperatures = temperatures;
        }
    }

    class Program
    {
        static void Main()
        {
            DailyTemperature[] dailyTemperatures =
            {
            new DailyTemperature(new DateTime(2021, 1, 21), 30, -15, new double[] { 0, 2, 5, 8, 10, 3, -2, -5 }),
            new DailyTemperature(new DateTime(2023, 6, 5), 8, -7, new double[] { -1, 1, 3, 6, 8, 2, -1, -3 }),
            new DailyTemperature(new DateTime(2024, 9, 1), 12, -28, new double[] { 1, 4, 7, 10, 12, 6, 1, -2 }),
            new DailyTemperature(new DateTime(2020, 3, 4), 5, -5, new double[] { -3, -1, 1, 3, 5, 0, -4, -8 })
        };

            DailyTemperature dayWithMaxDifference = dailyTemperatures.OrderByDescending(dt => dt.Highest_Temperature - dt.Lowest_Temperature).First();

            Console.WriteLine($"With the maximum difference between the highest and lowest temperature is {dayWithMaxDifference.Date} " +
                $"with a difference of {dayWithMaxDifference.Highest_Temperature - dayWithMaxDifference.Lowest_Temperature} degrees.");
        }
    }
}