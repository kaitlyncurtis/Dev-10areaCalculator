using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of the room: ");
            string length = Console.ReadLine();

            Console.Write("Enter the width of the room: ");
            string width = Console.ReadLine();

            Console.Write("Enter the overage percent: ");
            string overage = Console.ReadLine();

            decimal lengthDec = decimal.Parse(length);
            decimal widthDec = decimal.Parse(width);
            decimal overageDec = decimal.Parse(overage);


            Console.WriteLine($"The total area, including overage, is: {lengthDec*widthDec*((overageDec/100)+1)}");
        }
    }
}
