
using System;
// loop for execute the action for each loop;

namespace ThisIsIt
{
    class ClassName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running... ");
            System.Threading.Thread.Sleep(1000);

            for(int i = 0; i < 11; i++)
            {
                if(i == 5)
                {
                    Console.WriteLine("The half is: " + i);
                }
                else
                {
                    Console.WriteLine("Now the number is: " + i);
                }

            }

        }
    }
}