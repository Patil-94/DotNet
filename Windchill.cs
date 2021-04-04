using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    /// <summary>
    /// find windChill temp
    /// </summary>
    class Windchill
    {
        public static void ReadTemp()
        {
            Console.WriteLine("Enter the value of t ");
            int t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of v");
            int v = Convert.ToInt32(Console.ReadLine());
            temp(t, v); //calling temp() method
        }
        private static void temp(int t, int v)
        {
            if (t > 50 || (v > 120 || v < 3))    //put condition
            {
                Console.WriteLine("out of range");
            }
            else
            {
                double windchill = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16); //formula for find temp 
                Console.WriteLine(windchill);
            }
        }
    }
}