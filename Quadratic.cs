using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class Quadratic
    {
        /// <summary>
        /// find root of Quadratic equation 
        /// </summary>
        public static void ReadQuadratic()
        {
            Console.WriteLine("Enter the value of a");   //enter input
            int a = Convert.ToInt32(Console.ReadLine());  //convert to int with the help of convrt.ToInt32()
            Console.WriteLine("Enter the value of b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of c");
            int c = Convert.ToInt32(Console.ReadLine());

            double delta = b * b - (4 * a * c);      
            double sqr = Math.Sqrt(delta);
            double root1 = (-b + sqr) / (2 * a);     
            double root2 = (-b - sqr) / (2 * a);
            Console.WriteLine("the value of root1" + root1);   //print output
            Console.WriteLine("the value of root2" + root2);


        }
    }
}
