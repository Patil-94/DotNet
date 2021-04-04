using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    /// <summary>
    /// find euclidean distance
    /// </summary>
    class Distance
    {
        public static void ReadDistance()
        {
            Console.WriteLine("please enter x and y coordinates: ");   //enter the input 
            int x = Convert.ToInt32(Console.ReadLine()); //convert to int with the help of convert.ToInt32()
            int y = Convert.ToInt32(Console.ReadLine());
           
            Euclidean(x, y); //calling Eculidean() method
        }
        private static void Euclidean(int x, int y)
        {
            double distance = Math.Sqrt(x * x + y * y);     //formula to find distance
            Console.WriteLine(distance);  //finally print output

        }


    }
}