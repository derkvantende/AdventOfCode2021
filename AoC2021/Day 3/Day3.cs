using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_3
{
    public class Day3
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();
        List<int> count = new List<int>();
        string gamma = "";
        string epsilon = "";
        int bitWidth = 0;

        public Day3()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 3/Data.txt");
            data = file.getList();
        }

        public void fillCount()
        {
            int a = 0;
            foreach(string text in data)
            {
                if (a == 0)
                {
                    bitWidth = text.Length;
                    foreach (char c in text)
                        count.Add(0);
                }
                char[] arr = text.ToCharArray();
                for (int i = 0; i < text.Length; i++)
                    if (arr[i].Equals('1'))
                        count[i]++;
            }
        }

        public void defineBits()
        {
            fillCount();
            int numberOfLines = data.Count();
            for (int i = 0; i < bitWidth; i++)
            {
                if (count[i] > numberOfLines / 2)
                {
                    gamma += "1";
                    epsilon += "0";
                }
                else
                {
                    gamma += "0";
                    epsilon += "1";
                }
            }
        }

        public int getAnswerA()
        {
            defineBits();
            int gam = Convert.ToInt32(gamma, 2);
            int eps = Convert.ToInt32(epsilon, 2);
            return gam * eps;
        }

        public int getAnswerB()
        {
            return 0;
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\nThe multiplying returns {getAnswerA()}.");
            Console.WriteLine($"Answer B:\nThe multiplying returns {getAnswerB()}.");
        }
    }
}
