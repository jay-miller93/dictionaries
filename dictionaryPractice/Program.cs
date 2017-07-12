using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionaryPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            //{
            //    {"A1", "Twix" },
            //    {"A2", "Twizzlers" },
            //    {"A3", " Reeses" },
            //    {"A4", "Sour Patch Kids" }
            //};
            //foreach(KeyValuePair<string, string> item in snackMachine)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> drinkMachine = new Dictionary<int, string>();

            ////using add method to add drinks

            //drinkMachine.Add(10, "Ginger Ale");
            //drinkMachine.Add(11, "Disani");
            //drinkMachine.Add(12, "Orange Juice");
            //drinkMachine.Add(13, "Cherry Coke");
            //drinkMachine.Add(14, "Pepsi");
            ////Counting number of entrys in the dictionary
            //// Console.WriteLine(drinkMachine.Count);

            //foreach  (KeyValuePair<int,string> drink in drinkMachine)
            //{
            //    Console.WriteLine(drink.Key);
            //    Console.WriteLine(drink.Value);
            //}


            //create a dictionary for a theatre coat check with ten elements
            //key will be a number and value will be the coat style
            //print all elements to console

            //Dictionary<int, string> coatCheck = new Dictionary<int, string>();


            //coatCheck.Add(101, "Red coat");
            //coatCheck.Add(102, "Blue coat");
            //coatCheck.Add(103, "Orange coat");
            //coatCheck.Add(104, "Long coat");
            //coatCheck.Add(105, "Duster");
            //coatCheck.Add(106, "Green coat");
            //coatCheck.Add(107, "Vest");
            //coatCheck.Add(108, "Purple coat");
            //coatCheck.Add(109, "Yellow coat");
            //coatCheck.Add(110, "Pink coat");

            //foreach (KeyValuePair<int, string> coat in coatCheck)
            //{
            //    Console.WriteLine(coat.Key);
            //    Console.WriteLine(coat.Value);
            //}

            //create a dictionary for a  car valet with ten cars
            //the key will be a customers last name
            //value will be the car make
            //Dictionary<string, string> carValet = new Dictionary<string, string>()
            //{
            //    { "Miller", "Corvette" },
            //    { "Ice", "Escape" },
            //    { "Straw", "Beetle" },
            //    { "Handley", "Element" },
            //    { "Wilson", "Rogue" },
            //    { "Bires", "Toyota"},
            //    { "Smith", "Civic"},
            //    { "Robinson", "Farrari"},
            //    { "Pettibone", " Lambo"},
            //    { "Viviqua", "A Horse"}


            //};
            //foreach (KeyValuePair<string, string> item in carValet)
            //{
            //    Console.WriteLine(item);
            //}

            //create a dictionary of ten zoo animals
            //the key will be the animal type
            //the value will be the number of animals
            //print the animal with the highest quantity to the console
            //remove the zoo animal with the lowest quantity 

            Dictionary<string, int> zooAnimal = new Dictionary<string, int>();


            zooAnimal.Add("Tiger", 1);
            zooAnimal.Add("Deer", 108);
            zooAnimal.Add("Jaguars",4);
            zooAnimal.Add("Long coat Billy Goats",104);
            zooAnimal.Add("Axolotle", 15);
            zooAnimal.Add("Elephants", 8000);
            zooAnimal.Add("Lions",22);
            zooAnimal.Add("Purple coat Monkeys", 108);
            zooAnimal.Add("Yellow coat People eaters", 10003);
            zooAnimal.Add("Pink coat Skinks", 110);

            foreach (KeyValuePair<string, int> animal in zooAnimal)
            {
                Console.WriteLine(animal.Key);
                Console.WriteLine(animal.Value);
            }


        }
    }
}
