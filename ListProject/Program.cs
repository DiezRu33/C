

using System;
using System.Collections.Generic;

// List create as tacoShoppingFood;
List<string> tacoShoppingFood = new List<string>();
// Adding each element for List;
tacoShoppingFood.Add("fideos con tuco");
tacoShoppingFood.Add("helado de durazno");
tacoShoppingFood.Add("Cervezas");
tacoShoppingFood.Add("Manteca de guayaba");

Console.WriteLine("Los alimentos default son");

// loop for;
// using .Count instead of .Length;
for (int i = 0; i < tacoShoppingFood.Count; i++)
{
    // define valuenow to sum 0 + 1 and create a list w/ 1 as first;
    int valuenow = i + 1;
    Console.Write("\n" + valuenow + ": " + tacoShoppingFood[i] + "\n");
}

// Remove elements using ranges;
tacoShoppingFood.RemoveRange(1, 1);
Console.WriteLine("\n ------- \nEl resultado despues del remove es: ");

// loop with new results;
for (int i = 0; i < tacoShoppingFood.Count; i++)
{
    int valuenow = i + 1;
    // should use loop for to take the values in each count [i];
    Console.WriteLine(valuenow + ": " + tacoShoppingFood[i]);
}