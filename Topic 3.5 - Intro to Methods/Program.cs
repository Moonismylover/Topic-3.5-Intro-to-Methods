using System.Diagnostics.Contracts;

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
            // double means that this method will return a value when used. 
            // (double price) means that we need give the price of an item we wish to calculate the tax for. 
    
            const double taxRate = 0.13;
            return price * taxRate;
            // return is used to send a value back to the caller of the method. In this case, we are returning the calculated tax.

        }

        public static double Square(double number)
        {
            return number * number;
        }

        public static void Drawsquare()
        {
            Console.WriteLine(" ______ ");
            Console.WriteLine("|      |");
            Console.WriteLine("|      |");
            Console.WriteLine("|______|");
        }

        public static double FinalPrice(double price)
        {
            const double taxRate = 1.13;
            return price * taxRate;
        }

        public static double CircleCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        static void Main(string[] args)
        {
            Console.Title = "Intro to Methods";
            double itemPriceOne, taxOne, number, itemPriceTwo, taxTwo, radius;

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
            Console.WriteLine(" ");
            Drawsquare();
            Console.WriteLine(" ");

            itemPriceOne = 100;
            taxOne = CalculateTax(itemPriceOne);
            Console.WriteLine("Tax is " + taxOne.ToString("C"));

            Console.WriteLine(" ");

            number = 5;
            Console.WriteLine("The square of " + number + " is " + Square(number));
            Console.WriteLine(" ");

            itemPriceTwo = 100;
            taxTwo = FinalPrice(itemPriceTwo);
            Console.WriteLine("Final price is " + taxTwo.ToString("C"));
            Console.WriteLine(" ");

            radius = 2;
            Console.WriteLine("The circumference of a circle with radius " + radius + " is " + CircleCircumference(radius).ToString("F2"));

        }
    }
}
