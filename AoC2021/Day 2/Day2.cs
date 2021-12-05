using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2021.Day_2
{
    public class Day2
    {
        FileReader file = new FileReader();
        List<string> data = new List<string>();

        public Day2()
        {
            file.read("C:/Users/derk/Documents/AdventOfCode2021/AoC2021/Day 2/Data.txt");
            data = file.getList();
        }

        public List<Direction> stringToDirection()
        {
            List<Direction> list = new List<Direction>();
            foreach (string direction in data)
                list.Add(new Direction(getDirection(direction), getDistance(direction)));
            return list;
        }

        private string getDirection(string data)
        {
            return data.Contains(" ") ? data.Split(" ")[0] : data;
        }

        private int getDistance(string data)
        {
            return data.Contains(" ") ? Int32.Parse(data.Split(" ")[1]) : Int32.Parse(data);
        }

        public int getAnswerA()
        {
            List<Direction> list = stringToDirection();
            int horizontalPosition = 0;
            int depth = 0;

            foreach(Direction dir in list)
            {
                if (dir.getDirection().Equals("forward"))
                    horizontalPosition += dir.getDistance();
                if (dir.getDirection().Equals("up"))
                    depth -= dir.getDistance();
                if (dir.getDirection().Equals("down"))
                    depth += dir.getDistance();
            }

            return horizontalPosition * depth;
        }

        public int getAnswerB()
        {
            List<Direction> list = stringToDirection();
            int horizontalPosition = 0;
            int depth = 0;
            int aim = 0;

            foreach (Direction dir in list)
            {
                if (dir.getDirection().Equals("forward"))
                {
                    horizontalPosition += dir.getDistance();
                    depth += aim * dir.getDistance();
                }
                if (dir.getDirection().Equals("up"))
                    aim -= dir.getDistance();
                if (dir.getDirection().Equals("down"))
                    aim += dir.getDistance();
            }

            return horizontalPosition * depth;
        }

        public void printResult()
        {
            Console.WriteLine($"Answer A:\nThe multiplying returns {getAnswerA()}.");
            Console.WriteLine($"Answer B:\nThe multiplying returns {getAnswerB()}.");
        }
    }
}
