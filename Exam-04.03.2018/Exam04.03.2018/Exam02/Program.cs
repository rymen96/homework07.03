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


namespace Exam02
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());


            List<string> dna = Console.ReadLine().Split("!").ToList();
            var inputs = new List<string>();
            while (dna[0] != "Clone")
            {
                foreach (var item in dna)
                {
                    inputs.Add(item);
                }
                dna = Console.ReadLine().Split("!").ToList();

            }

            StringBuilder allInOneLines = new StringBuilder();

            

            
      
          
            
        }
    }
}
