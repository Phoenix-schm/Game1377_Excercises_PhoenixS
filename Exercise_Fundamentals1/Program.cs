namespace Exercise_Fundamentals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputStrings();
            Arithmetic();
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
        }
        static void Arithmetic()
        {
            // 2.
            // Declare two integers and do math with them
            Console.WriteLine("Input a number: ");
            int intInput1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input a number: ");
            int intInput2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(intInput1 + intInput2);                   // add intInput1 and intInput2
            Console.WriteLine(intInput1 - intInput2);                   // subtract intInput1 and intInput2
            Console.WriteLine(intInput1 * intInput2);                   // multiply
            Console.WriteLine((float)intInput1 / (float)intInput2);     // divide
            Console.WriteLine(intInput1 % intInput2);                   // modulo
        }
    }
}
