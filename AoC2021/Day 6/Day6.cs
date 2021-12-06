using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_6
{
    public class Day6
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();
        int counterA = 80;
        int counterB = 256;

        public Day6()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 6/Data.txt");
            data = file.getList();
        }

        public List<int> stringToInt()
        {
            List<int> list = new List<int>();
            foreach (string number in data)
                foreach (string n in number.Replace(" ", "").Trim().Split(","))
                    list.Add(Int32.Parse(n));
            return list;
        }

        public List<string> makeList(List<int> list)
        {
            int count0 = 0, count1 = 0, count2 = 0, count3 = 0, count4 = 0;
            int count5 = 0, count6 = 0, count7 = 0, count8 = 0;

            List<string> newList = new List<string>();
            foreach(int number in list)
            {
                if (number == 0) count0++;
                if (number == 1) count1++;
                if (number == 2) count2++;
                if (number == 3) count3++;
                if (number == 4) count4++;
                if (number == 5) count5++;
                if (number == 6) count6++;
                if (number == 7) count7++;
                if (number == 8) count8++;

            }
            newList.Add(count0.ToString());
            newList.Add(count1.ToString());
            newList.Add(count2.ToString());
            newList.Add(count3.ToString());
            newList.Add(count4.ToString());
            newList.Add(count5.ToString());
            newList.Add(count6.ToString());
            newList.Add(count7.ToString());
            newList.Add(count8.ToString());
            
            return newList;

        }

        public long countDays(List<string> list, int counter)
        {
            long nul = long.Parse(list[0]);
            list[0] = list[1];
            list[1] = list[2];
            list[2] = list[3];
            list[3] = list[4];
            list[4] = list[5];
            list[5] = list[6];
            list[6] = (long.Parse(list[7]) + nul).ToString();
            list[7] = list[8];
            list[8] = nul.ToString();

            if (counter > 1)
            {
                counter--;
                return countDays(list, counter);
            }

            long sum = 0;
            foreach (string number in list)
                sum += long.Parse(number);

            return sum;
        }

        public long getAnswerA()
        {
            return countDays(makeList(stringToInt()), counterA);
        }

        public long getAnswerB()
        {
            return countDays(makeList(stringToInt()), counterB);
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\nThe number of lanternfish is: {getAnswerA()}.");
            Console.WriteLine($"Answer B:\nThe number of lanternfish is: {getAnswerB()}.");
        }
    }
}
