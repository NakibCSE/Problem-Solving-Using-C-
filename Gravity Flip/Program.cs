using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GravityFlip
{
    internal class GravityFlip
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string Cubes = Console.ReadLine();
            string[] CubesArr = Cubes.Split(' ');
            int[] CubesArrInt = new int[CubesArr.Length];
            for (int i = 0; i < n; i++)
            {
                CubesArrInt[i] = int.Parse(CubesArr[i]);
            }
            Array.Sort(CubesArrInt);
            for (int i = 0; i < CubesArrInt.Length; i++)
            {
                Console.Write(CubesArrInt[i] + " ");
            }
        }
    }
}