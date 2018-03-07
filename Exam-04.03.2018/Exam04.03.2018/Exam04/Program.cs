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



namespace Exam04
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            var Dark = new SortedDictionary<string, string>();
            var ligh = new SortedDictionary<string, string>();

            var lists = new List<string>();
            int countLight = 0;
            int countDark = 0;
            while (inputs != "Lumpawaroo")
            {
                lists = inputs.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (inputs == "Lumpawaroo")
                {
                    break;
                }
                if (lists[1] == "|")
                {
                    if (lists[0] == "Light" || lists[0] == "Lighter")
                    {
                        if (Dark.ContainsKey(lists[2]))
                        {
                            ligh.Add(lists[2], "");
                            countLight++;
                            Dark.Remove(lists[2]);
                            countDark--;
                        }
                        else
                        {
                            ligh.Add(lists[2], "");
                            countLight++;
                        }
                    }
                    if (lists[0] == "Dark" || lists[0] == "Darker")
                    {
                        if (ligh.ContainsKey(lists[2]))
                        {
                            Dark.Add(lists[2], "");
                            countDark++;
                            ligh.Remove(lists[2]);
                            countLight--;
                        }
                        else
                        {
                            Dark.Add(lists[2], "");
                            countDark++;
                        }
                    }
                }
                if (lists[2] == "->")
                {
                    if (lists[3] == "Light" || lists[3] == "Lighter")
                    {
                        if (!ligh.ContainsKey(lists[0]) && !ligh.ContainsKey(lists[1]))
                        {
                            ligh.Add(lists[0], lists[1]);
                            countLight++;
                            Dark.Remove(lists[0]);
                            countDark--;
                            Console.WriteLine($"{lists[0]} {lists[1]} joins the Lighter side!");
                        }
                    }
                    if (lists[3] == "Dark" || lists[3] == "Darker")
                    {
                        if (!ligh.ContainsKey(lists[0]) && !ligh.ContainsKey(lists[1]))
                        {
                            Dark.Add(lists[0], lists[1]);
                            countLight--;
                            ligh.Remove(lists[0]);
                            countDark++;
                            Console.WriteLine($"{lists[0]} {lists[1]} joins the Darker side!");
                        }
                    }
                }
                if (lists[1] == "->")
                {
                    if (lists[2] == "Light" || lists[2] == "Lighter")
                    {
                        if (!ligh.ContainsKey(lists[0]) && !ligh.ContainsValue(lists[1])) ;
                        {
                            ligh.Remove(lists[0]);
                            ligh.Add(lists[0], "");
                            countLight++;
                            Dark.Remove(lists[0]);
                            countDark--;
                            Console.WriteLine($"{lists[0]} joins the Lighter side!");
                        }
                    }
                    if (lists[2] == "Dark" || lists[2] == "Darker")
                    {
                        if (!Dark.ContainsKey(lists[0]))
                        {
                            Dark.Add(lists[2], "");
                            countLight++;
                            ligh.Remove(lists[2]);
                            Console.WriteLine($"{lists[0]} joins the Darker side!");
                        }
                    }
                }
                inputs = Console.ReadLine();
            }
            if (countDark > 0)
            {
                Console.WriteLine($"Side: Dark, Members: {countDark}");
                foreach (var darks in Dark)
                {
                    Console.WriteLine($"! {darks.Key}");
                }
            }
            if (countLight > 1)
            {
                Console.WriteLine($"Side: Lighter, Members: {countLight}");
                foreach (var lights in ligh)
                {
                    Console.WriteLine($"! {lights.Key} {lights.Value}");
                }
            }

            else if (countLight > 0 && countLight <= 1)
            {
                Console.WriteLine($"Side: Light, Members: {countLight}");
                foreach (var lights in ligh)
                {
                    Console.WriteLine($"! {lights.Key}");
                }
            }
        }
    }
}
