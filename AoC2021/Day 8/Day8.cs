using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_8
{
    class Day8
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();

        public Day8()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 8/Data.txt");
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

        public long CountOverlap(string a, string b)
        {
            return a.Intersect(b).Count();
        }

        public long getAnswerA()
        {
            long counter = 0;
            foreach (string text in data)
                foreach (string n in text.Trim().Split(" | ")[1].Split(" "))
                    if (n.Length is 2 or 3 or 4 or 7) counter++;
            return counter;
        }

        public long getAnswerB()
        {
            List<List<string>> inputText = new List<List<string>>();
            List<List<string>> outputText = new List<List<string>>();
            long counter = 0;

            foreach(string text in data)
            {
                inputText.Add(text.Trim().Split(" | ")[0].Split(" ").ToList());
                outputText.Add(text.Trim().Split(" | ")[1].Split(" ").ToList());
            }

            for (int i = 0; i < data.Count(); i++)
            {
                string one = "", four = "", seven = "", eight = "";

                for (int j = 0; j < inputText[i].Count(); j++)
                {
                    if (inputText[i][j].Length is 2) one = inputText[i][j];
                    else if (inputText[i][j].Length is 4) four = inputText[i][j];
                    else if (inputText[i][j].Length is 3) seven = inputText[i][j];
                    else if (inputText[i][j].Length is 7) eight = inputText[i][j];
                }

                if (one == "" || four == "" || seven == "" || eight == "")
                    for (int j = 0; j < outputText.Count(); j++)
                    {
                        if (outputText[i][j].Length is 2) one = outputText[i][j];
                        else if (outputText[i][j].Length is 4) four = outputText[i][j];
                        else if (outputText[i][j].Length is 3) seven = outputText[i][j];
                        else if (outputText[i][j].Length is 7) eight = outputText[i][j];
                    }

                string number = "";

                foreach (string word in outputText[i])
                {
                    if (word.Length is 2) number += "1";
                    else if (word.Length is 4) number += "4";
                    else if (word.Length is 3) number += "7";
                    else if (word.Length is 7) number += "8";
                    else if (word.Length is 5)
                    {
                        long overlapOne = CountOverlap(one, word);
                        long overlapFour = CountOverlap(four, word);
                        long overlapSeven = CountOverlap(seven, word);
                        if (overlapOne is 1 && overlapFour is 2 && overlapSeven is 2) number += "2";
                        if (overlapOne is 2 && overlapFour is 3 && overlapSeven is 3) number += "3";
                        if (overlapOne is 1 && overlapFour is 3 && overlapSeven is 2) number += "5";
                    }
                    else if (word.Length is 6)
                    {
                        long overlapOne = CountOverlap(one, word);
                        long overlapFour = CountOverlap(four, word);
                        long overlapSeven = CountOverlap(seven, word);
                        if (overlapOne is 2 && overlapFour is 3 && overlapSeven is 3) number += "0";
                        if (overlapOne is 1 && overlapFour is 3 && overlapSeven is 2) number += "6";
                        if (overlapOne is 2 && overlapFour is 4 && overlapSeven is 3) number += "9";
                    }
                    else Console.WriteLine("ERROR!");
                }
                counter += long.Parse(number);
            }
            return counter;
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\nCount of digits: {getAnswerA()}");
            Console.WriteLine($"Answer B:\nCount of digits: {getAnswerB()}");
        }
    }
}
