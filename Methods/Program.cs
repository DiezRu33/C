
using System;
using System.Data;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            float[] pricesArray;

            pricesArray = new float[10];

            pricesArray[0] = 1.5f;
            pricesArray[1] = 2.3f;
            pricesArray[2] = 3f;
            pricesArray[3] = 6f;
            pricesArray[4] = 1.5f;

            Random rnd = new Random();

            Console.WriteLine("Hello world, of random numbers");
            Console.WriteLine($"{rnd.Next(1, 10)}");
        }
    }
}