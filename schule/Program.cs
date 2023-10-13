//using part5logic;

using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Reflection.Metadata;

namespace schule // Note: actual namespace depends on the project name. BLABLA ÄNDERUNG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //purchase();
            //purchaseWithList();
            //grading();
            //grading2();
            //GradingPerfected();
            //groceryShopping();
            //PDF6AufgabeA();
            //PDF6DoWhileA();
            //PDF6DoWhileB();
            //PDF6ForLoopA();
            //PDF6ForLoopB();
            //PDF6ForLoopC();
            //PDF6ForLoopD(); 
            //PDF6ForLoopE();
            //PDF6ForLoopF();
            //PDF6ForLoopG();
            //TEST2();
            //PDF6Aufgabe2();
            //PDF6Aufgabe3();
            //EinkaufsListe();
            //grading2();

            HackerRank HackerRank = new HackerRank();
            int steps = 8;
            string path = "DDUUUUDD";
            //HackerRank.countingValleys(steps, path);
            HackerRank.countingValleysMoreBeautifully(steps, path);
            int[] keyboards = new[] { 40, 50, 60 };
            int[] drives = new[] { 5, 8, 12 };
            int b = 60;
            //HackerRank.getMoneySpent(keyboards, drives, b);
            HackerRank.CORRECTmoneySpent(keyboards, drives, b);
        }

        public static void purchase()  // bad idea to use a dictionary, every entry needs to be unique. no doubling of the items
        {


            Console.WriteLine("\nWelcome to our corner store.\nHere is a list of our items.\n");
            IDictionary<string, double> listOfItems = new Dictionary<string, double>();
            listOfItems.Add("Beans", 3.99); //adding a key/value using the Add() method
            listOfItems.Add("Cucumber", 0.99);
            listOfItems.Add("Broccoli", 1.29);
            listOfItems.Add("Tomato", 0.99);
            listOfItems.Add("Peach", 0.69);
            foreach (KeyValuePair<string, double> kvp in listOfItems)
            {
                //Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }

            Console.WriteLine("How many items do you want to purchase?");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            string[] arrayOfItems = new string[numberOfItems];

            Console.WriteLine("Please enter the names of the items you want to pick, separate them with commas.");
            string chosenItems = Console.ReadLine();
            string[] nameOfItems = chosenItems.Split(',');
            for (int i = 0; i < nameOfItems.Length; i++)
            {
                nameOfItems[i] = nameOfItems[i].Trim();
            }
            IDictionary<string, double> PickedList = new Dictionary<string, double>();
            foreach (var item in nameOfItems)
            {
                if (!string.IsNullOrEmpty(item) && listOfItems.ContainsKey(item))
                {
                    PickedList.Add(item, listOfItems[item]);
                }
                else
                {
                    Console.WriteLine($"We don't have {item}.");
                }
            }
            Console.WriteLine("These are your picked items:\n");
            double totalPrice = 0;
            foreach (var item in PickedList)
            {
                Console.WriteLine(item.Key + ":" + item.Value);
                totalPrice += item.Value;
            }
            Console.WriteLine($"\nTotal cost of your purchase: {totalPrice}");
        }

        public static void purchaseWithList() // pretty dumb. no prices
        {
            Console.WriteLine("\nWelcome to our corner store.\nHere is a list of our items.\n");
            List<string> listOfItems = new List<string>();
            listOfItems.Add("Beans");
            listOfItems.Add("Cucumber");
            listOfItems.Add("Broccoli");
            listOfItems.Add("Tomato");
            listOfItems.Add("Peach");
            foreach (var item in listOfItems)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("How many items do you want to purchase?");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            string[] arrayOfItems = new string[numberOfItems];
            Console.WriteLine("Please enter the names of the items you want to pick, separate them with commas.");
            string chosenItems = Console.ReadLine();
            string[] nameOfItems = chosenItems.Split(',');
            for (int i = 0; i < nameOfItems.Length; i++)
            {
                nameOfItems[i] = nameOfItems[i].Trim();
            }
            List<string> PickedList = new List<string>();
            foreach (var item in nameOfItems)
            {
                if (!string.IsNullOrEmpty(item) && listOfItems.Contains(item))
                {
                    PickedList.Add(item);
                    Console.WriteLine($"\nYou picked {item}.\n");

                }
                else if (string.IsNullOrEmpty(item))
                {
                    Console.WriteLine($"You did not pick anything.");
                }
                else
                {
                    Console.WriteLine($"We don't have {item}.");
                }
            }
            Console.WriteLine("These are your picked items:\n");
            double totalPrice = 0;
            foreach (var item in PickedList)
            {
                Console.WriteLine(item);
                totalPrice += 1.99; // ???
            }
            Console.WriteLine($"\nTotal cost of your purchase: {totalPrice}");
        }

        public static void grading() // this method is WRONG
        {
            int scoredPoints;
            int grade = 100;

            Console.WriteLine("How much points did you get:");
            scoredPoints = Convert.ToInt32(Console.ReadLine());
            if (scoredPoints <= 20)
            {
                grade = 5;
            }
            else
            {
                for (int i = scoredPoints; i >= 20; i--)
                {
                    grade += 10;
                    //Console.WriteLine(grade);
                }
                int decimalgrade = grade / 10;
                Console.WriteLine(decimalgrade);
            }
        }
        public static void grading2()
        {
            {
                Console.WriteLine("Enter the score you reached (max is 60): ");
                int score = Convert.ToInt32(Console.ReadLine());

                if (score > 60 || score < 0)
                {
                    Console.WriteLine("Invalid score. Please enter a score between 0 and 60.");
                }
                else if (score <= 20)
                {
                    Console.WriteLine("Your grade is 5.");
                }
                else
                {
                    double grade = 1 + (60 - score) * 0.1;
                    Console.WriteLine($"Your grade is {grade}.");
                }
            }
        }
        public static void GradingPerfected()
        {
            bool validInput = false;
            int pointScore = 0;
            double gradeGeneral = 5;
            double grade = 5;

            const double gradeDecrement = 0.1;
            const double plusBorder = 0.66;
            const double minusBorder = 0.33;
            const int maxPoints = 60;
            const int minPoints = 20;
            const int lowestPoints = 0;

            while (!validInput)
            {
                Console.WriteLine("How much points did you score?");
                _ = int.TryParse(Console.ReadLine(), out pointScore);
                if (pointScore > maxPoints || pointScore < lowestPoints)
                {
                    Console.WriteLine("Invalid score\n");
                }
                else
                {
                    Console.WriteLine("Score valid\n");
                    validInput = true;
                }
            }

            if (pointScore < minPoints)
            {
                Console.WriteLine("Your grade: " + grade);
            }
            else
            {
                for (int i = pointScore; i > minPoints; i--)
                {
                    grade -= gradeDecrement;
                }
                Console.WriteLine($"Your grade: {Math.Round(grade, 2)}\n");
            }

            for (int i = minPoints + 1; i <= maxPoints; i++)
            {
                gradeGeneral -= gradeDecrement;

                string sign = string.Empty;
                double gradeWithoutDecimal = Math.Truncate(gradeGeneral);
                double decimalOfGrade = gradeGeneral - gradeWithoutDecimal;

                if (decimalOfGrade < minusBorder)
                {
                    sign = "+";
                }
                else if (decimalOfGrade > plusBorder)
                {
                    sign = "-";
                }

                Console.WriteLine($"Points: {i} --- Corresponding grade: {Math.Round(gradeGeneral, 2)} --- grade with sign {gradeWithoutDecimal}{sign}");
            }

        }
        public static void groceryShopping()
        {
            // Print a welcome message and a list of items to the console.
            Console.WriteLine("\nWelcome to our corner store.\nHere is a list of our items.\n");

            // Create a list of items available in the store.
            List<string> listOfItems = new List<string>() { "Beans", "Cucumber", "Broccoli", "Tomato", "Peach" };

            // Create a list of prices for each item. Each price corresponds to an item in the listOfItems.
            List<double> prices = new List<double>() { 1.99, 0.99, 1.49, 0.79, 0.49 };

            // Print each item and its price to the console.
            for (int i = 0; i < listOfItems.Count; i++)
            {
                Console.WriteLine($"{listOfItems[i]}: {prices[i]}");
            }

            // Ask the user how many items they want to purchase.
            Console.WriteLine("How many items do you want to purchase?");

            // Read the user's input and convert it to an integer.
            int numberOfItems = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the names of the items they want to purchase.
            Console.WriteLine("Please enter the names of the items you want to pick, separate them with commas.");

            // Read the user's input and split it into an array of strings.
            string chosenItems = Console.ReadLine();
            string[] nameOfItems = chosenItems.Split(',');

            // Trim any leading or trailing whitespace from each item name.
            for (int i = 0; i < nameOfItems.Length; i++)
            {
                nameOfItems[i] = nameOfItems[i].Trim();
            }

            // Create a list to store the items that the user picked.
            List<string> PickedList = new List<string>();

            // Initialize a variable to store the total price of the items that the user picked.
            double totalPrice = 0;

            // Check if each item that the user picked is in the list of items in the store.
            foreach (var item in nameOfItems)
            {
                if (!string.IsNullOrEmpty(item) && listOfItems.Contains(item))
                {
                    // If the item is in the list, add it to PickedList and add its price to totalPrice.
                    PickedList.Add(item);
                    totalPrice += prices[listOfItems.IndexOf(item)];
                    Console.WriteLine($"\nYou picked {item}.\n");
                }
                else if (string.IsNullOrEmpty(item))
                {
                    // If the item is an empty string, print a message saying that they did not pick anything.
                    Console.WriteLine($"You did not pick anything.");
                }
                else
                {
                    // If the item is not in the list, print a message saying that we don't have it.
                    Console.WriteLine($"We don't have {item}.");
                }
            }

            // Print a message indicating that these are the items that the user picked.
            Console.WriteLine("These are your picked items:\n");

            // Print each item that the user picked.
            foreach (var item in PickedList)
            {
                Console.WriteLine(item);
            }

            // Print the total cost of the items that the user picked.
            Console.WriteLine($"\nTotal cost of your purchase: {totalPrice}");
        }
        public static void PDF6AufgabeA()
        {
            int upperLimit = 0;
            while (upperLimit <= 100)
            {
                Console.WriteLine(upperLimit);
                upperLimit++;
            }
        }
        public static void PDF6AufgabeB()
        {
            Console.WriteLine("Already did this with the grocery shopping list stuff");
        }
        public static void PDF6DoWhileA()
        {
            int upperlimit = 0;
            do
            {
                Console.WriteLine(upperlimit);
                upperlimit++;
            }
            while (upperlimit <= 100);
        }
        public static void PDF6DoWhileB()
        {
            int upperlimit = 0;
            do
            {
                if (!(upperlimit % 2 == 0))
                {
                    Console.WriteLine(upperlimit);
                }
                upperlimit++;
            } while (upperlimit <= 100);
        }
        public static void PDF6ForLoopA()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i + " for loop");
            }
        }
        public static void PDF6ForLoopB()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write("Z");
                }
                Console.WriteLine();
            }
            for (int j = 0; j <= 10; j++)
            {
                Console.WriteLine("XXXXXXXXXXX");
            }



        }
        public static void PDF6ForLoopC()
        {
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }
        }
        public static void PDF6ForLoopD()
        {
            int totalRows = 20;
            Console.WriteLine("                 PYRAMID");
            for (int row = 1; row <= totalRows; row++)
            {
                for (int column = 1; column <= totalRows - row; column++)
                {
                    Console.Write(" ");                    
                }

                for (int amountX = 1; amountX <= 2 * row - 1; amountX++)
                {
                    Console.Write("X");                
                }

                Console.WriteLine();
            }
        }
        public static void PDF6ForLoopE()
        {           
            Console.WriteLine("             INVERTED PYRAMID");
            int totalRows = 20;           
            for (int row = totalRows; row >= 1; row--)
            {
                for (int column = 1; column <= totalRows - row; column++)
                {
                    Console.Write(" ");
                }

                for (int amountX = 1; amountX <= 2 * row - 1; amountX++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();
            }
        }
        public static void PDF6ForLoopF()
        {
            Console.WriteLine("Steps");
            int row = 20;
            for (int i= 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("X");
            }
            
        }
        public static void PDF6ForLoopG()
        {
            Console.WriteLine("Inverted Steps");
            int row = 20;
            for (int i = row; i >= 1; i--)
            {
                for (int j = 1; j < i ; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("X");
            }

        }
        public static void PYRAMID() 
        {
            int rows = 20;
            for (int i = 1;i <= rows; i++)
            {
                for(int j = 1;j <= rows - i; j++)
                {
                    Console.Write(" ");
                }
                for(int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("X");
                }
            }
        }
        public static void TEST2()
        {
            string words = "hallo";
            Console.Write(words);
            //Console.WriteLine();
            Console.Write(words);
        }
        public static void PDF6Aufgabe2()
        {
            for( int i = 1; i <= 10; i++)
            {
                if(i < 4)
                {
                    Console.WriteLine($"base = {i},    squared = {i * i},      cubed  = {i * i * i}");                    
                }
                else if (i >= 4 && i < 10)
                {
                    Console.WriteLine($"base = {i},    squared = {i * i},     cubed  = {i * i * i}");
                }
                else
                {
                    Console.WriteLine($"base = {i},   squared = {i * i},    cubed  = {i * i * i}");

                }

            }
        }
        public static void PDF6Aufgabe3()
        {
            Console.WriteLine("How many numbers do you want to have as a base?");

            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] potencyBase = new int[arraySize];
            int[] potencyExponent = new int[arraySize];
            Console.WriteLine();

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Type in the base, press enter for next input - Position {i + 1}: ");
                potencyBase[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();            

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Type in the exponent, press enter for next input - Position {i + 1}: ");
                potencyExponent[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("The numbers you entered are : ");
            for (int i = 0; i < arraySize; i++)
            {
                double result = Math.Pow(potencyBase[i], potencyExponent[i]);
                
                Console.WriteLine($"Base: {potencyBase[i]}, exponent: {potencyExponent[i]}, result: {result}");
            }
            Console.WriteLine();
            for (int j = 0; j < potencyBase.Length; j++)
            {
                int baseNumber = potencyBase[j];
                int exponentNumber = potencyExponent[j];
                string explicitCalc = "";
                char[] charstToTrim = { '*', ' ' };

                for (int i = 0; i < exponentNumber; i++)
                {
                    explicitCalc += baseNumber + " * ";
                }
                
                explicitCalc = explicitCalc.TrimEnd(charstToTrim);
                Console.WriteLine($"Calculation: {potencyBase[j]} ^ {potencyExponent[j]} = {explicitCalc} = {Math.Pow(potencyBase[j], potencyExponent[j])}");
            }
        }
        public static void EinkaufsListe()
        {
            Console.WriteLine("How many items would you like to purchase?");
            int amountOfItems;
            string userInput;
            while (true)
            {
                userInput = Console.ReadLine();
                try
                {
                    amountOfItems = Int32.Parse(userInput);
                    Console.WriteLine($"You chose to pick {amountOfItems} items.\n");
                    break;
                }
                catch
                {
                    Console.WriteLine("Your input is invalid. Please type in a number.");
                }

            }
            Console.WriteLine("This is the list of items we have:\n");
            Dictionary<string, int> items = new Dictionary<string, int>();
            
            string[] vegetables = new string[] { "Artichokes", "Arugula", "Asparagus", "Beets", "Bell peppers", "Black beans", "Bok choy", 
                "Broccoli", "Brussels sprouts", "Cabbage", "Carrots", "Cauliflower", "Celery", "Collard greens", "Corn", "Cucumbers", "Endive", 
                "Escarole", "Fennel", "French beans", "Garlic", "Ginger", "Green beans", "Green onions", "Green peas"};
            int[] serialnumbers = new int[25];
            for (int i = 0; i < serialnumbers.Length; i++)
            {
                serialnumbers[i] = i+ 1 ;
            }
            Random rand = new Random();
            for (int i = vegetables.Length -1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                string temp = vegetables[i];
                vegetables[i] = vegetables[j];
                vegetables[j]= temp;
            } 
            for(int i = 0;i<serialnumbers.Length;i++)
            {
                items.Add(vegetables[i], serialnumbers[i]);
            }
            foreach(KeyValuePair<string, int> pair in items)
            {
                if (pair.Value < 10)
                {
                    Console.WriteLine($"{pair.Value}:   {pair.Key}");
                }
                else
                {
                    Console.WriteLine($"{pair.Value}:  {pair.Key}");
                }
            }
            

        }
    }
}
