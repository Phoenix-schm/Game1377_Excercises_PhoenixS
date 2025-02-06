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
                        Console.WriteLine("Try again \n");
                        break;
                    }
            }
             
        }
        static void ArraysAndLoops()
        {
            // Part 2b

            // variable declaration
            string stringModifier = "";         // String must contain an empty string, not null, due to errors when equaling itself
            int[] intArray = { 100, 94, 159, -783, 132, 179, 47, 107, 135, 50 };

            // output array in reverse order
            for (int i = intArray.Length - 1; i >= 0; i--)
            {
                if (i == intArray.Length - 1)
                {
                    // if i is the first number in the index, then don't begin with a comma
                    // must have "" due to intArray being an int, won't consider it a string otherwise
                    stringModifier = "" + intArray[i];
                }
                else
                {
                   // else, start adding comma, add i to string for every loop
                    stringModifier = stringModifier + ", " + intArray[i];
                }
            }
            // once for loop has finished, show StringModifier in console.
            Console.WriteLine(stringModifier);
        }
    }
}
