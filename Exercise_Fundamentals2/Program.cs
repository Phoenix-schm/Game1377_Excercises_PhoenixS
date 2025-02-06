namespace Exercise_Fundamentals2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SwitchStatement();
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
                Console.WriteLine("Press a WASD key and press Enter:");

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
    }
}
