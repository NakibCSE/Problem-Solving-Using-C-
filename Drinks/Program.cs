using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drinks
{
    internal class Drinks
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += int.Parse(inputArray[i]);
            }
            double answer = sum / (n * 100.0);
            answer = answer * 100.0;
            Console.WriteLine(answer);
        }
    }
}