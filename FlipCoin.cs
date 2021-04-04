using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    /// <summary>
     /// Finding out percentage for head and tail while flipping coin
     /// </summary>
    class FlipCoin
    {
        //Reading input from user to flip coin
        public void ReadInput()
        {
            Console.WriteLine("please enter number of times to flip coin");
            string input = Console.ReadLine();
            //conver from string into int with the help conver.ToInt32()
            int numbofTimes = Convert.ToInt32(input);
            //calling flip() method to find percentage
            Flip(numbofTimes);
        }
        private static void Flip(int numofTimes)
        {
            //Initialization of local variables
            int tail = 0; int head = 0;
            //object creation for Predefined Random class
            Random random = new Random();
            //using for loop to itreate till condition fails
            for (int i = 1; i <= numofTimes; i++)
            {
                //using random function called NextDouble() to get random value range between 0 to 1
                if (random.NextDouble() < 0.5)
                {
                    //incrementing tail count by 1
                    tail++;
                }
                else
                    //incrementing head count by 1
                    head++;
            }
            //Applying formula to find percentage
            double tailpercentage = (double)tail / numofTimes * 100;
            double headpercentage = (double)head / numofTimes * 100;
            //finally printing count and also percentage for head and tail
            Console.WriteLine("Tail count" + "=" + tail + "\tpercentage " + tailpercentage);
            Console.WriteLine("head count" + "=" + head + "\tpercentage " + headpercentage);

        }


    }
}
