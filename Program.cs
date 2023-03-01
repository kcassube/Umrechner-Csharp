using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe den Wert ein der Umgewandelt werden soll (Binary/Octal/Hexadecimal/Decimal): ");
            string type = Console.ReadLine();

            Console.WriteLine("Enter the number: ");
            string input = Console.ReadLine();

            if (type == "Binary")
            {
                int dec = Convert.ToInt32(input, 2);
                Console.WriteLine("Decimal representation: " + dec);
                string hex = Convert.ToString(dec, 16);
                Console.WriteLine("Hexadecimal representation: " + hex);
                string oct = Convert.ToString(dec, 8);
                Console.WriteLine("Octal representation: " + oct);
            }
            else if (type == "Octal")
            {
                int dec = Convert.ToInt32(input, 8);
                Console.WriteLine("Decimal representation: " + dec);
                string hex = Convert.ToString(dec, 16);
                Console.WriteLine("Hexadecimal representation: " + hex);
                string bin = Convert.ToString(dec, 2);
                Console.WriteLine("Binary representation: " + bin);
            }
            else if (type == "Hexadecimal")
            {
                int dec = Convert.ToInt32(input, 16);
                Console.WriteLine("Decimal representation: " + dec);
                string bin = Convert.ToString(dec, 2);
                Console.WriteLine("Binary representation: " + bin);
                string oct = Convert.ToString(dec, 8);
                Console.WriteLine("Octal representation: " + oct);
            }
            else if (type == "Decimal")
            {
                int dec = int.Parse(input);
                string hex = Convert.ToString(dec, 16);
                Console.WriteLine("Hexadecimal representation: " + hex);
                string bin = Convert.ToString(dec, 2);
                Console.WriteLine("Binary representation: " + bin);
                string oct = Convert.ToString(dec, 8);
                Console.WriteLine("Octal representation: " + oct);
            }
            else
            {
                Console.WriteLine("Invalid type entered. Please try again.");
            }
            Console.ReadLine();
        }
    }
}
