namespace Exercise_Fundamentals1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputStrings();
        }
        static void OutputStrings()
        {
            // 1.
            // Declare a string
            string gameString = "I’m in Game 1377: Scripting for Game Designers";

            Console.WriteLine(gameString);                  // Output string to new line
            Console.WriteLine(gameString.ToUpper());        // Output string in upper case
            Console.WriteLine(gameString.ToLower());        // Output string in lower case
            Console.WriteLine(gameString.Substring(8));     // Output string starting at index 8
            Console.WriteLine(gameString.Substring(8, 3));  // Output string from index 8 to 11
            Console.WriteLine(gameString.Substring(8, 1));  // Output only index 8 string

        }
    }
}
