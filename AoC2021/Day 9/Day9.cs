using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_9
{
    class Day9
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();
        long counter = 0;

        public Day9()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 9/Data.txt");
            data = file.getList();
        }

        public long getAnswerA()
        {
            return -1;
        }

        public long getAnswerB()
        {
            return -1;
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\nCheapest outcome: {getAnswerA()}");
            Console.WriteLine($"Answer B:\nCheapest outcome: {getAnswerB()}");
        }
    }
}
