using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            purchase();
        }

        public static void purchase()
        {
            // bad idea to use a dictionary, every entry needs to be unique. no doubling of the items

            Console.WriteLine("\nWelcome to our corner store.\nHere is a list of our items.\n");
            IDictionary<string, double> listOfItems = new Dictionary<string, double>();
            listOfItems.Add("Beans", 3.99); //adding a key/value using the Add() method
            listOfItems.Add("Cucumber", 0.99);
            listOfItems.Add("Broccoli", 1.29);
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

        public static void grading()
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
        
    }
}
