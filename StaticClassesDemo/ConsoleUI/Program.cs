using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHello();
            UserMessages.SayGoodMorning();
            Console.ReadLine();
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello World!");
        }
        public static double GetADouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();
            double output;

            bool isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.WriteLine("That was not a valid number. Please try again.");
                Console.Write(message);
                numberText = Console.ReadLine();

                isDouble = double.TryParse(numberText, out output);
            }

            return output;
        }

    }
}
