using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our corner store.\nHere is a list of our items.\n");
            IDictionary<double, string> listOfItems = new Dictionary<double, string>();
            listOfItems.Add(3.99, "Beans"); //adding a key/value using the Add() method
            listOfItems.Add(0.99, "Cucumber");
            listOfItems.Add(1.29, "Broccoli");            
            foreach (KeyValuePair<double, string> kvp in listOfItems)
            {
                //Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
                Console.WriteLine($"{kvp.Value} {kvp.Key}");
            }

            Console.WriteLine("How many items do you want to purchase?");
            int numberOfItems = Convert.ToInt32(Console.ReadLine());
            string[] arrayOfItems = new string[numberOfItems];

            Console.WriteLine("Please enter the names of the items you want to pick, separate them with commas.");
            string chosenItems = Console.ReadLine();
            string[] nameOfItems = chosenItems.Split(',');
            for (int i = 0; i < chosenItems.Length; i++)
            {
                nameOfItems[i] = nameOfItems[i].Trim();
            }
            IDictionary<string, double> PickedList = new Dictionary<string, double>();
            foreach (var item in nameOfItems)
            {
                if (!string.IsNullOrEmpty(item) && listOfItems.Contains(item)) 
                {
                    PickedList.Add(item, listOfItems[item]);
                }
                else
                {
                    Console.WriteLine("We dont have that item.");
                }
            }

            /*
            Console.WriteLine($"Please enter {numberOfItems} items you want to purchase, press enter after each input.");

            for (int i = 0; i < numberOfItems; i++)
            {
                arrayOfItems[i] = Console.ReadLine();
            }

            

            foreach (string d in arrayOfItems)
            {
                Console.WriteLine(d);
            }
            */

            /*
            double average = sum / 6;
            Console.WriteLine("===============================================");
            Console.WriteLine("The Values you've entered are");
            Console.WriteLine("{0}{1,8}", "index", "value");
            for (int counter = 0; counter < 6; counter++)
                Console.WriteLine("{0,5}{1,8}", counter, arrayOfItems[counter]);
            Console.WriteLine("===============================================");
            Console.WriteLine("The average is ;");
            Console.WriteLine(average);
            Console.WriteLine("===============================================");
            Console.WriteLine("would you like to search for a certain elemnt ? (enter yes or no)");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "yes":
                    Console.WriteLine("===============================================");
                    Console.WriteLine("please enter the array index you wish to get the value of it");
                    int index = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("===============================================");
                    Console.WriteLine("The Value of the selected index is:");
                    Console.WriteLine(arrayOfItems[index]);
                    break;

                case "no":
                    Console.WriteLine("===============================================");
                    Console.WriteLine("HAVE A NICE DAY SIR");
                    break;
            }
            */
        }
        
    }
}
