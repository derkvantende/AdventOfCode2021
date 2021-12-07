using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_4
{
    public class Day4
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();

        public Day4()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 4/Data.txt");
            data = file.getList();
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\n");
            Console.WriteLine($"Answer B:\n");
        }
    }
}
