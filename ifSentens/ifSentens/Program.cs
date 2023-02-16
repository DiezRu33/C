
using System;
using System.Runtime.InteropServices;

namespace NamespaceName
{
    class ClassName
    {
        static void Main(string[] args)
        {
            int anyvalue = 14;
            string message = "";

            if (anyvalue == 7)
            {
                message = "*I'm the message & the value is 7";
            }else if(anyvalue == 14){
                message = "The value is 14 too.";
            }
            else
            {
                Console.WriteLine("Not correct value");
            }
            Console.WriteLine($"\nThe message is:{message}\n");

            Console.WriteLine($"Running... ");
        }
    }
}