using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicDemo
{
    class ReplaceString
    {
        /// <summary>
        /// Reading input from user
        /// </summary>
        public static void ReadInput()
        {
            //given string template
            string template = "Hello <<UserName>>, How are you?";
            //given instruction/message to the user
            Console.WriteLine("please enter your name");
            //Reading input from user
            string userInput = Console.ReadLine();
            //calling replace() method
            Replaceword(template, userInput);
        }
        /// <summary>
        /// created replace() method to perform replacement
        /// </summary>
        /// <param name="template"></param>
        /// <param name="UserInput"></param>
        private static void Replaceword(string template, string UserInput)
        {
            //using predefined string Replace() method to perform replace opration
            string result = template.Replace("<<UserName>>", UserInput);
            //finally displaying updated template/statement
            Console.WriteLine("After done replace " + result);
        }

    }
}



