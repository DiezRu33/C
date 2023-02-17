

using System;

namespace myProject
{
    class myMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running...");

            Console.WriteLine("Esta es una calculadora...");

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("\nQue operaciòn queres hacer?: \n" +
                            "Suma\n" +
                            "Resta\n" +
                            "Multiplicaciòn\n" +
                            "Divisiòn");
                        string choice = Console.ReadLine();

                while (true)
                {
                if (choice == "Suma" || choice == "suma" || choice == "1")
                {
                    Console.WriteLine("Elegì el primer numero a sumar:");
                    float firstNumber = float.Parse(Console.ReadLine());

                    Console.WriteLine("Elegì el segundo número a sumar");
                    float secondNumber = float.Parse(Console.ReadLine());

                    float result = firstNumber + secondNumber;
                    Console.WriteLine("El resultado es: " + result);
                    break;

                }
                else if (choice == "Resta" || choice == "resta" || choice == "2")
                {
                    Console.WriteLine("Elegì el primer numero a restar:");
                    float firstNumber = float.Parse(Console.ReadLine());

                    Console.WriteLine("Elegì el segundo número a restar");
                    float secondNumber = float.Parse(Console.ReadLine());

                    float result = firstNumber - secondNumber;
                    Console.WriteLine("El resultado es: " + result);

                    break;


                }
                else if (choice == "Multiplicacion" || choice == "multiplicacion" || choice == "3")
                {

                    Console.WriteLine("Elegì el primer numero a multiplicar:");
                    float firstNumber = float.Parse(Console.ReadLine());

                    Console.WriteLine("Elegì el segundo número a multiplicar");
                    float secondNumber = float.Parse(Console.ReadLine());

                    float result = firstNumber * secondNumber;
                    Console.WriteLine("El resultado es: " + result);
                    break;

                }
                else if (choice == "division" || choice == "Division" || choice == "4")
                {

                    Console.WriteLine("Elegì el primer numero a dividir:");
                    float firstNumber = float.Parse(Console.ReadLine());

                    Console.WriteLine("Elegì el segundo número a dividir");
                    float secondNumber = float.Parse(Console.ReadLine());

                    float result = firstNumber / secondNumber;
                    Console.WriteLine("El resultado es: " + result);
                    break;

                }else if(choice == "close" || choice == "exit")
                    {
                        Environment.Exit(0);
                    }
                else
                {
                    Console.WriteLine("Que onda flaco no era tan dificil\n");
                    break;
                }
            }
            }
        }
    }
}