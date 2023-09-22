using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schule
{
    internal class part5logic
    {
        public static void task3()
        {
            //write a console program that tells you if a number
            // is in between 0 and 40 or if the number has the value 42
            // only use one if-statement

            Console.WriteLine("Type in a number:");
            string userInput = Console.ReadLine();

            int numberInput;
            bool successfulInput = int.TryParse(userInput, out numberInput);
            
            if (successfulInput && numberInput > 0 && numberInput < 40 || successfulInput && numberInput == 42 )
            {
                Console.WriteLine("Your input is a number. In the range of 0 - 40 or the number 42");
            }else if (successfulInput && numberInput < 0 || numberInput > 40) 
            {
                Console.WriteLine(""); // hier weitermachen !           
            }
        }
    }
}
