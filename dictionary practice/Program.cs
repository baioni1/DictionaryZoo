using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, int> studentScores = new Dictionary<string, int>();
            //studentScores.Add("studentA", 89);
            //studentScores.Add("studentB", 75);
            //studentScores.Add("studentC", 94);
            //studentScores.Add("studentD", 98);
            //foreach (KeyValuePair<string, int> student in studentScores)
            //{
            //    Console.WriteLine(studentScores["studentC"]);

            //}

            //a dictionary of style coats(value) with a key(the number)
            //Dictionary<string, int> customerCoats = new Dictionary<string, int>();
            //customerCoats.Add( 1,"trench");
            //customerCoats.Add("parka", 2);
            //customerCoats.Add("pea", 3);
            //customerCoats.Add("chesterfield", 4);
            //customerCoats.Add("military", 5);
            //customerCoats.Add("cape", 6);
            //customerCoats.Add("cocoon", 7);
            //customerCoats.Add("toggle", 8);
            //customerCoats.Add("duffle", 9);
            //customerCoats.Add("top", 10);

            //foreach(KeyValuePair<string,int>coats in customerCoats)
            //{
            //    Console.WriteLine(coats);
            //}

            //a dictionary using two strings(Key is first in the () and the value is second
            //Dictionary<string, string> customerCars = new Dictionary<string, string>();
            //customerCars.Add("Mazaradi", "Alandale");
            //customerCars.Add("Mazda", "Blakemore");
            //customerCars.Add("Chrysler", "Jameson");
            //customerCars.Add("Ford", "Sweeney");
            //customerCars.Add("Bentley", "Markson");
            //foreach(KeyValuePair<string,string>cars in customerCars)
            //{
            //    Console.WriteLine(cars);
            //}

            
             
            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            zooAnimals.Add("zebra", 9);
            zooAnimals.Add("panda", 2);
            zooAnimals.Add("kangaroo", 36);
            zooAnimals.Add("flamingo", 102);
            zooAnimals.Add("tiger", 4);
            zooAnimals.Add("Eagle", 1);
            zooAnimals.Add("Elephant", 7);
            zooAnimals.Add("myrakat", 29);
            zooAnimals.Add("seal", 12);
            zooAnimals.Add("bear", 3);
            zooAnimals.Remove("Eagle");
            
            var holder = 0;
           
            Console.WriteLine("Pick an animal name and see if we have that animal at the zoo");
            string userAnimal = Console.ReadLine();

            if (zooAnimals.ContainsKey(userAnimal) == true)
            {
                Console.WriteLine("Yes, we have {0} at our zoo", userAnimal);
            }
            else
            {
                Console.WriteLine("Sorry, we don't have that animal at our zoo,\n Would you like to add the animal to our zoo? Y/N");
                string userAnswer = Console.ReadLine();
                userAnswer = userAnswer.ToUpper();
                if(userAnswer == "Y")
                {
                    Console.WriteLine("What animal would you like to add?");
                    string animalAdd = Console.ReadLine();
                    animalAdd = animalAdd.ToLower();
                    Console.WriteLine("How many {0}'s do you want at the zoo?",animalAdd);
                    int numAnimals = int.Parse(Console.ReadLine());
                    
                    if (zooAnimals.ContainsKey(animalAdd) == false)
                    {
                        zooAnimals.Add(animalAdd, numAnimals);                       
                        Console.WriteLine("We have added {0} to the zoo!", animalAdd);
                    }
                    else 
                    {                        
                        Console.WriteLine("We already have that Animal at our zoo!");
                    }
                                        
                }
                else
                {
                    Console.WriteLine("Check back with us, we are always adding new animals");
                }
            }
            var animals = from pair in zooAnimals orderby pair.Value ascending select pair;
            foreach (KeyValuePair<string, int> printAnimals in animals)
            {
                Console.WriteLine(printAnimals);
            }
            
            Console.WriteLine("We have {0} different animals at the zoo!",zooAnimals.Count);

            foreach (var zooAnimal in zooAnimals)
            {
                if (zooAnimal.Value > holder)
                {
                    holder = zooAnimal.Value;
                }
            }
            foreach (var highValue in zooAnimals)
            {
                if (highValue.Value == holder)
                {
                    Console.WriteLine("We have {0} {1}'s at the zoo!:", highValue.Value, highValue.Key);
                }

            }
        }
    }
}
