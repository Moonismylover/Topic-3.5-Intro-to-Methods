namespace Topic_3._5___Intro_to_Methods
{
    internal class Program
    {
        public static void DrawCheck()
        {
            // void means it does not return any value. It just performs a task and then exits.
            // DrawCheck is the name of the method.

            Console.WriteLine("     /");
            Console.WriteLine("    /");
            Console.WriteLine("\\  /");
            Console.WriteLine(" \\/ ");

            // Backslash is an escape character, so to print a backslash, we need to use two backslashes.
        }

        public static void DrawX()
        {
            Console.WriteLine("\\  /");
            Console.WriteLine(" \\/ ");
            Console.WriteLine(" /\\");
            Console.WriteLine("/  \\");
            // Backslash is an escape character, so to print a backslash, we need to use two backslashes.
        }

        public static double CalculateTax(double price)
        {
            const 
        }

        static void Main(string[] args)
        {
            Console.Title = "Intro to Methods";

            /* 
              Method is a re-usable block of code that performs a specific task. 
              It can be called multiple times throughout the program.
            */

            /*
              Use methods when:
                1) Repeating code
                2) Isolation of a block of code 
            */

            Console.WriteLine("Hello, World!");
            Console.WriteLine(" ");
            DrawCheck();
            Console.WriteLine(" ");
            DrawX();


        }
    }
}
