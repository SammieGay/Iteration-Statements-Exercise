using System;


namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void allThousand()
        {
            for (int i = -1000; i <=1000; i++)
            {
                Console.WriteLine($"{i}");
            }
        }



        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void threeAtATime()
        {
            for (int e = 3; e <= 999; e += 3)
            {
                Console.WriteLine($"{e}");
            }
        }



        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void equalOrNot(int a, int b)
        {
            if(a == b)
            {
                Console.WriteLine("The numbers are equal.");
            }
            else
            {
                Console.WriteLine("The numbers are not equal.");
            }
        }

        
        //Write a method to check whether a given number is even or odd
        public static void evenOrOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even.");
            }
            else
            {
                Console.WriteLine($"{num} is odd.");
            }
        }

        
        //Write a method to check whether a given number is positive or negative
        public static void posOrNegative()
        {
            Console.WriteLine("Please input a number.");

            int userInput = int.Parse(Console.ReadLine());

            if(userInput < 0)
            {
                Console.WriteLine($"{userInput} is negative.");
            }
            else
            {
                Console.WriteLine($"{userInput} is positive.");
            }

        }


        
        //Write a method to read the age of a candidate and determine whether they can vote
        public static void ageToVote()
        {
            Console.WriteLine("Please enter your age.");

            int userAge = int.Parse(Console.ReadLine());

            if (userAge >= 18)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote.");
            }
        }
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void range()
        {
            Console.WriteLine("Pick a number between -10 and 10.");
            int userNum = int.Parse(Console.ReadLine());
            if(userNum >= -10 && userNum <= 10)
            {
                Console.WriteLine($"{userNum} is in the specified range.");
            }
            else
            {
                Console.WriteLine($"{userNum} is not in the specified range.");
            }

        }
        
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void multiply()
        { 
            int userNumber;
            int multiplier;

            Console.WriteLine("Please input a number to see the multiplication table for it.");
            userNumber = int.Parse(Console.ReadLine());

            for(multiplier = 1; multiplier <= 12; multiplier++)
            {
                Console.WriteLine("{0} * {1} = {2}", userNumber, multiplier, (userNumber * multiplier));
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }


        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            allThousand();
            threeAtATime();
            equalOrNot(5, 5);
            evenOrOdd(5);
            posOrNegative();
            ageToVote();
            range();
            multiply();
        }
    }
}
