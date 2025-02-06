using System.Collections;

namespace Exercise_Fundamentals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchStatement();
            ArraysAndLoops();
        }

        static void SwitchStatement()
        {
            // variable declarations
            // Const strings for possible future changes
            const string W = "w";
            const string A = "a";
            const string S = "s";
            const string D = "d";

            bool switchReturn = true;

            while (switchReturn)
            {
                // Part 1: takes user input for only the WASD key presses
                //         Switch statment for processing key presses
                Console.WriteLine("Input a WASD key");

                string? userInput;
                userInput = Console.ReadLine();
                switch(userInput)
                    {
                    case W:
                        Console.WriteLine("You moved up");
                        switchReturn = false;
                        break;
                    case A:
                        Console.WriteLine("You moved left");
                        switchReturn = false;
                        break;
                    case S:
                        Console.WriteLine("You moved down");
                        switchReturn = false;
                        break;
                    case D:
                        Console.WriteLine("You moved right");
                        switchReturn = false;
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                    }
                Console.WriteLine("\n");
            }
             
        }
        static void ArraysAndLoops()
        {
            // Part 2

            // variable declaration
            int[] intArray = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };

            ReverseArrayOrder("", intArray);          // String parameter must contain an empty string, not null,
                                                      //        due to errors when equaling itself
            UserInputCheck(true, intArray);
            ArrayAverage(0, intArray);

        }

        static void ReverseArrayOrder(string sentence, int[] array)
        {
            // 2b
            // outputs array in reverse order
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (i == array.Length - 1)
                {
                    // if 'i' is the first number in the index, then don't begin with a comma
                    // must have "" due to array being an int, won't consider it a string otherwise
                    sentence = "" + array[i];
                }
                else
                {
                    // else, start adding comma, add i to string for every loop
                    sentence = sentence + ", " + array[i];
                }
            }
            // once for loop has finished, show StringModifier in console.
            Console.WriteLine(sentence);
        }

        static void UserInputCheck(bool boolean, int[] array)
        {
            // 2c
            // checks if the user has typed one of the numbers in array

            //variable declarations
            string? stringUserInput;                                    // allows for null strings
            int intUserInput;        
            
            Console.WriteLine("Write one of the list numbers:");
            while (boolean)
            {
                //variable initialization in while loop, resets every loop
                stringUserInput = Console.ReadLine();                   // Take user input
                int.TryParse(stringUserInput, out intUserInput);        // Parses stringUserInput for integers and stores it in intUserInput,
                                                                        //        TryParse() allows for null strings

                // if the user input is NOT a null
                if (stringUserInput != null)
                {
                    foreach (int i in array)
                    {
                        // checks the entire array for if intUserInput is equal to 'i' (cannot be done with stringUserInput due to comparison with int 'i'
                        if (intUserInput == i)
                        {
                            Console.WriteLine("Hurray! You typed one of the numbers");
                            boolean = false;                             // boolean becomes false, breaks while loop
                        }
                    }
                }
                // tells user to try again if boolean still true
                // must be stored in if statement otherwise will state "Try Again" regardless of new boolean
                if (boolean == true)
                {
                    Console.WriteLine("You didn't type one of the numbers from the array. Try again");
                }
            }
        }
        static void ArrayAverage(int average, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                average = average + array[i];
            }
            average = average / array.Length;
            Console.WriteLine(average.ToString());
        }
    }
}
