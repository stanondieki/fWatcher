using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace filewatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"D:\try\sample.txt";

            List<string> lines = File.ReadAllLines(filepath).ToList();

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

            lines.Add("space");

            File.WriteAllLines(filepath, lines);

            Console.ReadLine();


        }
    }
}
