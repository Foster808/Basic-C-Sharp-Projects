using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        
        // STEP 1
        int userChoice;
        Console.WriteLine("Choose a number between 0 and 8 to hear your fortune!");
        userChoice = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();
        Console.WriteLine("Great you chose: " + userChoice);
        List<string> intList = new List<string>();
        intList.Add("This will be a stellar day for you!");
        intList.Add("The full moon has got your back all month!");
        intList.Add("You will have a great day!");
        intList.Add("Uh oh. Looks like you've got a bit of laundry to do.");
        intList.Add("You will have a smooth day!");
        intList.Add("Maybe you should go grocery shopping tonight.");
        intList.Add("Do you really have enough toilet paper?");
        intList.Add("You have everything you need!");
        intList.Add("This is your LUCKY day!!!!!!!!!!!!!!");

        Console.WriteLine(intList[userChoice]);
        Console.ReadLine();


        //STEP 2

        int userChoice1;
        Console.WriteLine("Choose a number between 0 and 4 to hear your potential bonus jackpot this year!");
        userChoice1 = Convert.ToInt32(Console.ReadLine());
        Console.ReadLine();
        
        int[] numArray = new int[5];  // arrays are a c# concept called objects. 
        numArray[0] = 1000;
        numArray[1] = 500;
        numArray[2] = 10000;
        numArray[3] = 100;
        numArray[4] = 3000;

        bool guessedWrong = true;

        do
        {
            switch (userChoice1)
            {
                case 0:
                    Console.WriteLine("You could potentially get: ");
                    Console.WriteLine(numArray[userChoice1]);
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 1:
                    Console.WriteLine("You could potentially get: ");
                    Console.WriteLine(numArray[userChoice1]);
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 2:
                    Console.WriteLine("You could potentially get: ");
                    Console.WriteLine(numArray[userChoice1]);
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.WriteLine("You could potentially get: ");
                    Console.WriteLine(numArray[userChoice1]);
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.WriteLine("You could potentially get: ");
                    Console.WriteLine(numArray[userChoice1]);
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
                case 5:
                    Console.WriteLine("You could potentially get: ");
                    Console.WriteLine(numArray[userChoice1]);
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("That is not a number in the 0 to 5 range.");
                    Console.WriteLine("Try again.");
                    //userChoice1 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
        }
        while (!guessedWrong);
        Console.ReadLine();

        //Console.WriteLine("You could potentially get: ");
        //Console.WriteLine(numArray[userChoice1]);
        //Console.ReadLine();



        //STEP 3 within STEP 2

        //STEP 4

        int userChoice2;
        Console.WriteLine("Last number, to add some SHINE to your day and money, choose from 0 to 6");
        userChoice2 = Convert.ToInt32(Console.ReadLine());


        string[] wordArray = { "BOOM", "POW", "SPARKLE", "PIZAZZ", "GEN-I-US", "BRILLIANT", "SPECTACULAR" };




        Console.WriteLine("Bing, Bang, Boom, Voila... " + wordArray[userChoice2]);
        Console.ReadLine();




    }

}
