using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventCode
{
    class Program
    {
        
        public void PartOne(string path)
        {
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            for (int x = 0; x < lines.Count; x++)
            {
              int val = 2020 - Int32.Parse(lines[x]); //get the number that remains when the number(x) is subtracted from 2020

              if (lines.Contains(val.ToString()))
                  {
                     Console.WriteLine("*************************** Part 1 **************************************");
                     Console.WriteLine("Values = " + Int32.Parse(lines[x]) + " * " + val);
                     Console.WriteLine($"Answer =  {Int32.Parse(lines[x]) * val}");
                  }
                
            }
        }
        public void PartTwo(string path)
        {
            List<string> lines = new List<string>();

            lines = File.ReadAllLines(path).ToList();

            for (int x = 0; x < lines.Count; x++)
            {
                for (int y = x++; y < lines.Count; y++)
                {
                    int val = 2020 - Int32.Parse(lines[x]) - Int32.Parse(lines[y]);

                    if (lines.Contains(val.ToString()))
                    {
                        Console.WriteLine("*************************** Part 2 **************************************");
                        Console.WriteLine("Values = " + Int32.Parse(lines[x]) + " * " + Int32.Parse(lines[y]) +" * "+ val);
                        Console.WriteLine($"Answer =  {Int32.Parse(lines[x]) * Int32.Parse(lines[y]) * val}");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            string filePath = @"C:\Users\Mokgadi Shibambu\source\repos\AdventCode\AdventCode\DayOnePartOne.txt";

            p.PartOne(filePath);
            p.PartTwo(filePath);

          
        }

    }
}
