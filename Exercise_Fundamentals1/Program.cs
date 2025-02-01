namespace Exercise_Fundamentals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputStrings();
            Arithmetic();
            Assignment();
            ComparisonAndConditionals();
        }
        static void OutputStrings()
        {
            // 1.
            // Declare a string
            string gameString = "I’m in Game 1377: Scripting for Game Designers";

            Console.WriteLine(gameString);                  // Output string to new line
            Console.WriteLine(gameString.ToUpper());        // Output string in upper case
            Console.WriteLine(gameString.ToLower());        // Output string in lower case
            Console.WriteLine(gameString.Substring(7));     // Output string starting at letter 8
            Console.WriteLine(gameString.Substring(7, 3));  // Output string from letter 8 to 11
            Console.WriteLine(gameString.Substring(7, 1));  // Output only letter 8

            Console.WriteLine("\n"); // for additional readable in console
        }
        static void Arithmetic()
        {
            // 2.
            // Declare two integers that take user input and do math with them
            // WriteLine personal addition for readability in console
            Console.WriteLine("Input an integer: ");
            int intInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input another integer: ");
            int intInput2 = Convert.ToInt32(Console.ReadLine());

            // put intInput's through arithmetic modifiers
            // 
            Console.WriteLine(intInput1 + " + " + intInput2 + " = " + (intInput1 + intInput2));
            Console.WriteLine(intInput1 + " - " + intInput2 + " = " + (intInput1 - intInput2));
            Console.WriteLine(intInput1 + " * " + intInput2 + " = " + (intInput1 * intInput2));
            Console.WriteLine(intInput1 + " / " + intInput2 + " = " + ((float)intInput1 / intInput2));
            Console.WriteLine(intInput1 + " % " + intInput2 + " = " + (intInput1 % intInput2));

            Console.WriteLine("\n");
        }
        static void Assignment()
        {
            // Declare two floats
            float floatInput1,floatInput2;

            // floatInput's are equal to user input
            Console.WriteLine("Input a float:");
            floatInput1 = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Input a float:");
            floatInput2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("\n");

            floatInput2 = floatInput1 + floatInput2;            // as seen, assignment does not clarify to show in console
            floatInput2 = floatInput1 - floatInput2;
            floatInput2 = floatInput1 * floatInput2;
            floatInput2 = floatInput1 / floatInput2;
        }
        static void ComparisonAndConditionals()
        {
            // 4.
            // Declare two integers that take user input
            int intInput1, intInput2;

            Console.WriteLine("Input a integer:");
            intInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input another integer:");
            intInput2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            // Create a long if else statement of comparisons
            if (intInput1 == intInput2)
            {
                Console.WriteLine(intInput1 + " is equal to " + intInput2);
            }
            else if (intInput1 != intInput2)                                    // this could've been a plain 'else' 
            {                                                                   // but didn't know based on the exercise asking to use !=
                if (intInput1 > intInput2)
                {
                    Console.WriteLine(intInput1 + " is greater than " + intInput2);
                }
                else if (intInput1 < intInput2)
                {
                    Console.WriteLine(intInput1 + " is less than " + intInput2);
                }
                else if (intInput1 >= intInput2)
                {
                    Console.WriteLine(intInput1 + " is greater than or equal to " + intInput2);
                }
                else if (intInput1 <= intInput2)
                {
                    Console.WriteLine(intInput1 + " is less than or equal to " + intInput2);
                }
            }
            else
            {
                Console.WriteLine("You aren't supposed to be here.");
            }
        }
    }
}
