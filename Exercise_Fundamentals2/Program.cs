using System.Collections;

namespace Exercise_Fundamentals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SwitchStatement();
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

            //ReverseArrayOrder("", intArray);            // String parameter must contain an empty string, not null,
            //        due to errors when equaling itself
            UserInputCheckInArray(true, intArray);
            //ArrayAverage(0, intArray);                  // int parameter must be 0 due to errors when equaling itself
            //SkipANumber(intArray, 2);
            //SkipANumber(intArray, 3);
            ArrayCreation();

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
            // once for loop has finished, show sentence in console.
            Console.WriteLine(sentence);
        }

        static void UserInputCheckInArray(bool boolean, int[] array)
        {
            // 2c
            // checks if the user has typed one of the numbers in array      
            int intUserInput;

            while (boolean)
            {
                intUserInput = InputCheck("Write one of the listed numbers:", false);

                foreach (int i in array)
                    {
                    // checks the entire array for if intUserInput is equal to 'i' (cannot be done with stringUserInput due to comparison with int 'i'
                    if (intUserInput == i)
                    {
                        Console.WriteLine("Hurray! You typed one of the numbers");
                        boolean = false;                             // boolean becomes false, breaks while loop
                    }
                }
                if (boolean == true)
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        static void ArrayAverage(int average, int[] array)
        {
            // 2d
            // add numbers in array and divide by array length to create its average
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            average /= array.Length;
            Console.WriteLine(average.ToString() + "\n");
        }
        static void SkipANumber(int[] array, int x)
        {
            // 2e and 2f
            for (int i = 0; i < array.Length; i++)
            {
                int comparison = i % x;

                // output every other number in array
                if (x == 2)
                {
                    if (comparison == 0)
                    {
                        continue;
                    }
                    Console.WriteLine(array[i]);
                }

                // output every third number in array
                else if (x == 3)
                {
                    if (comparison == 0 || comparison == 1)
                    {
                        continue;
                    }
                    Console.WriteLine(array[i]);
                }
            }
            Console.WriteLine("\n");
        }
        static void ArrayCreation()
        {
            int arraySize;
            int rangeMin;
            int rangeMax;

            arraySize = InputCheck("Input an array size:", true);       // arraySize input, cannot be zero
            rangeMin = InputCheck("Input minimum range size", false);   // minimum range input, could technically be zero
            rangeMax = InputCheck("Input a maximum range size", false);

            int[] newArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                //newArray[i] = 
            }

        }
        static int InputCheck(string userPrompt, bool cantBeZero)
        {
            int userInput = 0;                                      // cannot start at null due to TryParse
            string? stringUserInput;


            while(true)
            {
                Console.WriteLine(userPrompt);                      // Prompt the user
                stringUserInput = Console.ReadLine();               // Take user input
                Console.WriteLine("\n");
                int.TryParse(stringUserInput, out userInput);       // Parses stringUserInput for integers and stores it in 'integer',
                                                                    //        TryParse() allows for null strings
                
                bool stringCheck = stringUserInput.All(char.IsDigit); // returns true if stringUserInput contains a number

                if (stringUserInput == null || stringUserInput == "")
                {
                    Console.WriteLine("Cannot input nothing. Try again");
                }
                else if (cantBeZero == true && userInput == 0)       // in the event that the player is not allowed to input zero
                {
                    Console.WriteLine("Cannot input zero. Try again.");
                }
                else if (stringCheck)
                {
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Try again.");
                }
            }            
        }
    }
}
