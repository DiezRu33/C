using System;

namespace Namespace
{
    class ClassName
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running... \n");

            string[] coffeTypes;
            float[] coffeValues;

            coffeTypes = new string[] { "expresso", "largo", "filtrado", "latte" };

            coffeValues = new float[] { 1.2f, 1.5f, 5, 5.6f };

            // changing the value of position nmb 1 for "Lungo";
            coffeTypes[1] = "Lungo";

            // while 0 stay lower than lenght of coffe types, loop continue;
            for (int i = 0; i < coffeTypes.Length; i++)
            {
                Console.WriteLine("El valor del café " + coffeTypes[i] + " es de: " + coffeValues[i] + "USD");

            }
        }
    }
}