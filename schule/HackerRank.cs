using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schule
{
    internal class HackerRank
    {
        public int countingValleys(int steps, string path)
        {
            int height = 0;
            int valleyCounter = 0;
            char[] UpOrDown = path.ToCharArray();

            foreach (char direction in UpOrDown)
            {
                if (direction == 'U')
                {
                    height++;
                }
                else if (direction == 'D')
                {
                    height--;
                    if (height == -1) 
                    {
                        valleyCounter++;
                    }
                }                
            }
            Console.WriteLine($"The amount of valleys: {valleyCounter}");
            return valleyCounter;
        }
        public int countingValleysMoreBeautifully(int steps, string path)
        {
            int height = 0;
            int valleyCounter = 0;
            char[] pathArray = path.ToCharArray();

            foreach (char direction in pathArray)
            {
                int previousHeight = height;
                height += (direction == 'U') ? 1 : -1;

                if (previousHeight == 0 && height == -1)
                {
                    valleyCounter++;
                }
            }
            Console.WriteLine($"The amount of valleys: {valleyCounter}");
            
            return valleyCounter;
        }
        public int getMoneySpent(int[] keyboards, int[]drives, int b) // not correct
        {
            int sum = 0;
            foreach(int entry in keyboards)
            {
                for (int i = 0; i < keyboards.Length; i++)
                {
                    sum = entry+ drives[i];
                }                
            }
            if (sum <= b)
            {
                Console.WriteLine($"Sum: {sum}");
                return sum;
            }
            else
            {
                Console.WriteLine($"Too expensive: {-1}");
                return -1;
            }
        }
        public int CORRECTmoneySpent(int[] keyboards, int[]drives, int b)
        {
            int maxSpent = -1;

            foreach (int keyboard in keyboards)
            {
                foreach (int drive in drives)
                {
                    int total = keyboard + drive;

                    if (total <= b && total > maxSpent)
                    {
                        maxSpent = total;
                    }
                }
            }
            Console.WriteLine("moneySpent: " +  maxSpent);
            return maxSpent;
        }
        public static void KaprekarNumbers(int p, int q)
        {
            bool isKaprekarNumber = false;
            for (long i = p; i <= q; i++)
            {
                long squaredNumber = i * i;
                string squaredString = squaredNumber.ToString();

                string rightSide = squaredString.Substring(squaredString.Length - i.ToString().Length);
                string leftSide = squaredString.Substring(0, squaredString.Length - rightSide.Length);
                if (leftSide.Length == 0)
                {
                    leftSide = "0";
                }

                int rightNumber = Convert.ToInt32(rightSide);
                int fused = int.Parse(leftSide) + rightNumber;

                //Console.WriteLine($"{i:D2} --> L: {leftSide}, R: {rightSide}  --> Fused: {fused}");

                if (fused == i)
                {
                    Console.Write($"{i} ");

                    isKaprekarNumber = true;
                }
            }
            if (!isKaprekarNumber)
            {
                Console.WriteLine("INVALID RANGE");
            }
        }
    }
}
