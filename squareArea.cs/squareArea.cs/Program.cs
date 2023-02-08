using System;

namespace NameSpace
{
    class ClassName
    {
        static void Main(string[] args)
        {
            // read user input;
            // parsing the float to convert the float to string;

            Console.WriteLine("Enter the side A parameter: ");

            float sideA = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the side B parameter: ");

            float sideB = float.Parse(Console.ReadLine());

            // rectangle area formula is a*b;
            float area = sideA * sideB;
            float randomNumber = 10.5f;

            Console.WriteLine("The result is: " + area + "\nRandom number: " + randomNumber);
        }
    }
}