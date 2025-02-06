using System.Collections;

namespace Exercise_Fundamentals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variable declarations
            // Const strings for possible future changes
            const string W = "w";
            const string A = "a";
            const string S = "s";
            const string D = "d";

            int[] intArray = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };
            float[] floatArray = { 0.123f, 0.20394f, 9.234f, 90.234f };
            double[] doubleArray = { 324.23421d, 943.4324223d, 98.484823d };

            string sentence = "";                   // String sentence must contain an empty string, not null,
            string? stringUserInput;

            int intUserInput;
            int average = 0;

            bool whileBool = true;
            bool switchReturn = true;

            int arraySize;
            int rangeMax;
            int rangeMin;
            var rand = new Random();


#region Part 1
            while (switchReturn)
            {
                // Part 1: takes user input for only the WASD key presses
                //         Switch statment for processing key presses
                Console.WriteLine("Input a WASD key");

                string? userInput;
                userInput = Console.ReadLine();
                switch (userInput)
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
            #endregion
#region Part 2
            // 2b
            // outputs array in reverse order
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                if (i == intArray.Length - 1)
                {
                    // if 'i' is the first number in the index, then don't begin with a comma
                    // must have "" due to array being an int, won't consider it a string otherwise
                    sentence = "" + intArray[i];
                }
                else
                {
                    // else, start adding comma, add i to string for every loop
                    sentence = sentence + ", " + intArray[i];
                }
            }
            // once for loop has finished, show sentence in console.
            Console.WriteLine(sentence);
            sentence = "";                          //reset sentence

            // 2c
            // checks if the user has typed one of the numbers in array      
            intUserInput = 0;
            Console.WriteLine("Write one of the numbers in the array");
            while (whileBool)
            {
                stringUserInput = Console.ReadLine();                   // Take user input
                int.TryParse(stringUserInput, out intUserInput);        // Parses stringUserInput for integers and stores it in intUserInput,

                
                foreach (int i in intArray)
                {
                    // checks the entire array for if intUserInput is equal to 'i' (cannot be done with stringUserInput due to comparison with int 'i'
                    if (intUserInput == i || stringUserInput == "-783")
                    {
                        Console.WriteLine("Hurray! You typed one of the numbers");
                        whileBool = false;                             // boolean becomes false, breaks while loop
                        break;
                    }
                }
                if (whileBool == true)                                  // must be contained within if statement, will display otherwise
                {
                    Console.WriteLine("Try again");
                }
            }
            NewLine();

            // 2d
            // add numbers in array and divide by array length to create its average
            for (int i = 0; i < intArray.Length; i++)
            {
                average += intArray[i];
            }
            average /= intArray.Length;
            Console.WriteLine("The average of this array is " + average.ToString() + "\n");

            //2e
            // skip every other number in array
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }
            NewLine();

            // 2f
            // skip every third number in array
            for (int i = 0; i < intArray.Length; i++)
            {
                if (i % 3 == 0 || i % 3 == 1)
                {
                    continue;
                }
                Console.WriteLine(intArray[i]);
            }
            NewLine();

            // 2g
            // Take in user input to create a custom array. Each element of array should be random form arrayMin - arrayMax
            arraySize = InputCheck("Input an array size:", true, false, 0);             // arraySize input, cannot be zero
            rangeMin = InputCheck("Input a minimum size for array:", false, false, 0);   // minimum range input, could technically be zero
            rangeMax = InputCheck("Input a maximum size for the array:", false, true, rangeMin);

            int[] customArray = new int[arraySize];                        // create an array with index size of arraySize

            foreach (int i in customArray)                                 // fills the new array with a random number for each index
            {
                customArray[i] = rand.Next(rangeMin, rangeMax);
                Console.WriteLine(customArray[i]);
            }
            NewLine();



            #endregion

            ArrayOrder(intArray, "");            // String parameter must contain an empty string, not null,
            OverloadArrayOrder(floatArray);
            OverloadArrayOrder(doubleArray);
            IntToFloatAverage(intArray);
            OverloadAverage(floatArray);
            OverloadAverage(doubleArray);

            ArrayCreation(arraySize, rangeMin, rangeMax, rand);
        }

#region Assignment Part 3
        static void ArrayOrder(int[] array, string sentence)
        {
            // 3a     Modified from 2b

            // outputs array in order from left to right
            for (int i = 0; i < array.Length; i++)
            {
                if (i == 0)
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
            NewLine();

        }
        static float[] OverloadArrayOrder(float[] array)
        {
            // 3b
            // an overloaded method that can output all elements in a float array
            for (int i = 0; i < array.Length;i++)
            {
                Console.WriteLine(array[i]);
            }
            NewLine();
            return array;
        }
        static double[] OverloadArrayOrder(double[] array)
        {
            // 3b
            // an overloaded method that can output all elements in a double array
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            NewLine();
            return array;
        }
        static void IntToFloatAverage(int[] array)
        {
            // 3c
            // outputs the average of an int array as a float
            float average = 0;
            for(int i = 0;i < array.Length; i++)
            {
                average += array[i];
            }
            Console.WriteLine("The average of an int array is " + (average / array.Length));
            NewLine();
        }
        static float OverloadAverage(float[] array)
        {
            // 3d
            // an overloaded method that outputs the average in a float array
            float average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            Console.WriteLine("The average of a float array is " + (average / array.Length));
            NewLine();
            return average;
        }
        static double OverloadAverage(double[] array)
        {
            // 3d an overloaded method that outputs the average in a double array
            double average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                average += array[i];
            }
            Console.WriteLine("The average of a double array is " + (average / array.Length));
            NewLine();
            return average;
        }
        static void ArrayCreation(int size, int min, int max, Random var)
        {
            size = InputCheck("Input an array size:", true, false, 0);       // arraySize input, cannot be zero
            min = InputCheck("Input a minimum size for the array:", false, false, 0);   // minimum range input, could technically be zero
            max = InputCheck("Input a maximum size for the array:", false, true, min);

            int[] newArray = new int[size];                        // create an array with index size of arraySize 

            foreach (int i in newArray)                                 // fills the new array with a random number for each index
            {
                newArray[i] = var.Next(min, max);
                Console.WriteLine(newArray[i]);
            }
            NewLine();
        }

        #endregion

        #region Misc
        static int InputCheck(string userPrompt, bool cantBeZero, bool cantBeLess, int lessComparison)
        {
            int userInput = 0;                                      // cannot start at null due to TryParse
            string? stringUserInput;


            while(true)
            {
                Console.WriteLine(userPrompt);                      // Prompt the user
                stringUserInput = Console.ReadLine();               // Take user input
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
                else if (cantBeLess == true && userInput < lessComparison)      // additional parameters, insures rangeMax cannot be less than rangeMin
                {
                    Console.WriteLine("Input cannot be less than " + lessComparison + ". Try again");
                }
                else if (stringCheck)
                {
                    NewLine();
                    return userInput;
                }
                else
                {
                    Console.WriteLine("Try again.");
                }
            }            
        }
        static void NewLine()
        {
            Console.WriteLine("\n");
        }
#endregion
    }
}
