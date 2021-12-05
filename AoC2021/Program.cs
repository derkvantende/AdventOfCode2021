using System;

namespace AoC2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Day 1:");
            Day_1.Day1 day1 = new Day_1.Day1();
            day1.printResult();

            Console.WriteLine("\nDay 2:");
            Day_2.Day2 day2 = new Day_2.Day2();
            day2.printResult();

            Console.WriteLine("\nDay 3:");
            Day_3.Day3 day3 = new Day_3.Day3();
            day3.printResult();
        }
    }
}
