using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_7
{
    public class Day7
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();

        public Day7()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 7/Data.txt");
            data = file.getList();
        }

        public List<long> stringToInt()
        {
            List<long> list = new List<long>();
            foreach (string number in data)
                foreach (string n in number.Trim().Split(","))
                    list.Add(long.Parse(n));
            return list;
        }

        public long getAnswerA()
        {
            long count = 0;
            for (long i = stringToInt().Min(); i <= stringToInt().Max(); i++)
            {
                long countA = 0;
                foreach (long number in stringToInt())
                {
                    if (number < i)
                        countA += i - number;
                    if (number > i)
                        countA += number - i;
                }
                if (countA < count || count == 0)
                    count = countA;
            }
            return count;
        }

        public long getAnswerB()
        {
            long count = 0;
            for(long i = stringToInt().Min();i<=stringToInt().Max();i++)
            {
                long countA = 0;
                foreach (long number in stringToInt())
                {
                    if (number < i)
                    {
                        long c = 0;
                        for (long j = 1; j <= i - number; j++)
                            c += j;
                        countA += c;
                    }
                    if (number > i)
                    {
                        long c = 0;
                        for (long j = 1; j <= number - i; j++)
                            c += j;
                        countA += c;
                    }
                }
                if (countA < count || count == 0)
                    count = countA;
            }
            return count;
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\nCheapest outcome: {getAnswerA()}");
            Console.WriteLine($"Answer B:\nCheapest outcome: {getAnswerB()}");
        }
    }
}
