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


namespace Exam03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var encruptedMessage = Console.ReadLine().ToArray();
            string removePatern = @"[STARstar]";

            for (int i = 0; i < n; i++)
            {
                encruptedMessage = Console.ReadLine().ToArray();
            }


        }
    }
}
