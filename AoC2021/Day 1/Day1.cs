using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_1
{
    public class Day1
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();
        int counterA = 0;
        int counterB = 0;

        public Day1()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 1/Data.txt");
            data = file.getList();
        }

        public List<int> stringToInt()
        {
            List<int> list = new List<int>();
            foreach (string number in data)
                list.Add(Int32.Parse(number));
            return list;
        }

        //Answer part A
        public void checkIfIncreased()
        {
            int last = 10000;
            List<int> list = stringToInt();

            foreach(int number in list)
            {
                if (number > last)
                    counterA++;
                last = number;
            }
        }

        //Answer part B
        public void checkIfAllIncreased()
        {
            List<int> list = stringToInt();

            for (int i = 0; i < list.Count() - 3; i++)
                if (list[i] + list[i + 1] + list[i + 2] < list[i + 1] + list[i + 2] + list[i + 3])
                    counterB++;
        }

        public void printResult()
        {
            checkIfIncreased();
            Console.WriteLine($"Answer A:\nThere are {counterA} measurements higher than the previous measurement.");
            checkIfAllIncreased();
            Console.WriteLine($"Answer B:\nThere are {counterB} measurements higher than the previous measurement.");
        }
    }
}
