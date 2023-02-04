
using System;

namespace Name
{
    class ClassName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");

            int height = 170;
            int age = 20;
            string name = "Leonel Messi";
            string PlaceholderText = "The information you requested is :";
            string information = PlaceholderText + name + age;
            Console.WriteLine("Mi nombre es : " + name + ". \n Tengo " + age + " años. \n Y peso " + height + "kg.");
        }
    }
}