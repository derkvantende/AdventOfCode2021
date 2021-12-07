using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_5
{
    public class Day5
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();
        int counterA = 0;
        int counterB = 0;

        public Day5()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 5/Data.txt");
            data = file.getList();
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\n");
            Console.WriteLine($"Answer B:\n");
        }
    }
}
