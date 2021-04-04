using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class LeapYear
    {

        public void ReadInput()
        {
            Console.WriteLine("Enter the year in four digits : ");
            string input = Console.ReadLine();
            //conver from string into int with the help conver.ToInt32()
            int year = Convert.ToInt32(input);
            //calling leap() method to find leapyear 
            leap(year);
        }
        private static void leap(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))  //condition for finding leap year 
            {
                Console.WriteLine("leap year");
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
