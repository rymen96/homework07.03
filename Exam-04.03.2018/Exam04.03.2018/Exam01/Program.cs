using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam01
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            decimal countOfStudents = decimal.Parse(Console.ReadLine());
            decimal priceOfLightsabers = decimal.Parse(Console.ReadLine());
            decimal priceOfRobes = decimal.Parse(Console.ReadLine());
            decimal priceOfBelts = decimal.Parse(Console.ReadLine());
            decimal belts = 0;
            decimal freeBelts = 0;

            if (countOfStudents > 6)
            {
                belts = countOfStudents / 6;
                freeBelts = belts;
            }

            decimal percents = (countOfStudents *10)/100;

            decimal sum = priceOfLightsabers * Math.Ceiling(countOfStudents + percents) + priceOfRobes*(countOfStudents) + priceOfBelts *Math.Ceiling(countOfStudents - freeBelts);
            decimal sumForAllStudents = sum;


            if (sumForAllStudents <= amountOfMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {sumForAllStudents:F2}lv.");
            }
            if (sumForAllStudents > amountOfMoney)
            {
                decimal diffrence = sumForAllStudents - amountOfMoney;
                Console.WriteLine($"Ivan Cho will need {diffrence:F2}lv more.");
            }
        }
    }
}
