using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //purchase();
            //purchaseWithList();
            //grading();
            //grading2();
            GradingPerfected();
            //groceryShopping();
        }

        public static void purchase()
        {
            // bad idea to use a dictionary, every entry needs to be unique. no doubling of the items

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
            listOfItems.Add("Beans"); //adding a key/value using the Add() method
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
                totalPrice += 1.99;
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

            for (int i = minPoints + 1 ; i <= maxPoints; i++)
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

    }
}
