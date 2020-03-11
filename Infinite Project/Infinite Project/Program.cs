using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infinite_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // STEP 1
            Console.WriteLine("What is your name?");
            string name = Convert.ToString(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("Hi, " + name + ", nice to meet you!");
            Console.ReadLine();

            string[] names = { "Now ", "we ", "can ", "be ", "friends ", name , "!"};
            foreach (string i in names)

            Console.WriteLine(i);
            Console.ReadLine();

            // STEP 2 -- Create an INFINITE LOOP
            // STEP 3 -- Fix the INFINITE LOOP
            for (int j = 0; j < 50; j--)
            {
                Console.WriteLine("value : {0}", j);
                break;
            }
            Console.ReadLine();


            // STEP 4 -- Create a loop where the comparison used to determine 
            //whether to continue iterating the loop is a “<” operator

            string[] names1 = { "Lara", "Gretchen", "Julie", "Katie", "Amanda" };

            for (int k = 0; k < names1.Length; k++)
            {
                Console.WriteLine(names1[k]);
            }
            Console.ReadLine();

            // STEP 5 -- Create a loop where the comparison used to determine
            //whether to continue iterating the loop is a “<=” operator.

            List<int> mainRatings = new List<int>();
            mainRatings.Add(99);
            mainRatings.Add(72);
            mainRatings.Add(90);
            mainRatings.Add(64);
            mainRatings.Add(85);

            foreach (int score in mainRatings)
            {
                if (score <= 85)
                {
                    Console.WriteLine("These are failing tv ratings: " + score);
                }
            }
            Console.ReadLine();

            // STEP 6 -- Create a List of strings where each item in the list is unique. 
            //Ask the user to input text to search for in the List. Create a loop that iterates through the loop and then 
            //displays the index of the array that contains matching text on the screen.

            Console.WriteLine("Pick a vegetable that may be on our grocery list! Hint: they start with C, L, C, E or S!");
            string userveggie = Convert.ToString(Console.ReadLine()); 
            Console.ReadLine();

            List<string> groceryList = new List<string>() { "Carrots", "Lettuce", "Celery", "Eggplant", "Spinach" };

            //foreach (string veggie in groceryList)
            foreach (string veggie in groceryList)
                {
                if (userveggie == "Carrots")
                {
                    Console.WriteLine("You picked one: " + userveggie);
                    break;
                }
                else if (userveggie == "Lettuce")
                {
                    Console.WriteLine("You picked one: " + userveggie);
                    break;
                }
                else if (userveggie == "Celery")
                {
                    Console.WriteLine("You picked one: " + userveggie);
                    break;
                }
                else if (userveggie == "Eggplant")
                {
                    Console.WriteLine("You picked one: " + userveggie);
                    break;
                }
                else if (userveggie == "Spinach")
                {
                    Console.WriteLine("You picked one: " + userveggie);
                    break;
                }
                else
                {
                    Console.WriteLine("That's not iiiiiit! Try Again.");
                    Console.WriteLine("Guess another veggie?");
                    string userVeggie = Convert.ToString(Console.ReadLine());
                }
            }
          
            Console.ReadLine();

            // STEP 7 
            //  Add code to that above loop that tells a user if they put in text that isn’t in the List.
            // STEP 8
            // Add code to that above loop that stops it from executing once a match has been found.

            //STEP 9 
            // Create a List of strings that has at least two identical strings in the List. Ask the 
            //user to select text to search for in the List. Create a 
            //loop that iterates through the loop and then displays the 
            //indices of the array that contain matching text on the screen.

            Console.WriteLine("Let's talk about favorite words.");
            Console.WriteLine("These are mine, BOOM, KA-POW, ZINGA, BING, BLOOP.");
            Console.WriteLine("Which one of the above is your favorite?");
            string userWord = Convert.ToString(Console.ReadLine());
            Console.ReadLine();


            List<string> favWords = new List<string>();
            favWords.Add("BOOM");
            favWords.Add("KA-POW");
            favWords.Add("ZINGA");
            favWords.Add("BING");
            favWords.Add("BLOOP");

            foreach (string userWord1 in favWords)
            {
                    Console.WriteLine(string.Join("\n", favWords));
                    Console.ReadLine();
                    Console.WriteLine("We've got a match with " + userWord + " Yeeeeeee-hawwww!");
                    Console.ReadLine();
                    break;
                
            }
            Console.ReadLine();

            // STEP 10
            // Add code to that above loop that tells a user if they put in text that isn’t in the List.

            // STEP 11
            // Create a List of strings that has at least two identical strings in the List. Create a 
            // foreach loop that evaluates each item in the list, and displays a message showing the 
            // string and whether or not it has already appeared in the list.

            Console.WriteLine("Pick one of these names that might have a double, Lara, Gretchen, Julie or Amanda?");
            string doubleName = Convert.ToString(Console.ReadLine());
            Console.ReadLine();

            List<string> names8 = new List<string>() { "Lara", "Gretchen", "Julie", "Amanda", "Lara" };

            foreach (string doubleName1 in names8)
            {
                if (doubleName == "Lara")
                {
                    Console.WriteLine(doubleName);
                    Console.WriteLine("You found the double!!!");
                    break;
                }
                else if (doubleName != "Lara")
                {
                    Console.WriteLine("Try Again!");
                    doubleName = Convert.ToString(Console.ReadLine());
                }
            }
            Console.WriteLine("That was fun!");
            Console.ReadLine();



        }
    }
    }




