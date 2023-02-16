using System;
using System.Security.Cryptography.X509Certificates;

public class MyMethods
    {
    // con void no retornan valores;
    public void IntegerAddition(int a, int b)
    {
        int Addition = a + b;
        Console.WriteLine("El resultado es: " + Addition);
    }

    public int IntegerMultiplication(int a, int b)
    {
        int Multiplication = a * b;
        return Multiplication;
    }

    public int IntegerReduce(int a, int b)
    {
        int Redox = a - b;
        return Redox;
    }

    public float Division(float a , float b)
    {
        float result = a / b;
        return result;
    }

    public static void Main()
    {
        MyMethods MyProgram = new MyMethods();

        MyProgram.IntegerAddition(3, 6);

        int result = MyProgram.IntegerMultiplication(5, 10);
        Console.WriteLine("Final result: " + result);

        int result2 = MyProgram.IntegerReduce(100, 50);
        Console.WriteLine("Final result: " + result2);

        float result3 = MyProgram.Division(24, 5);
        Console.WriteLine("Final result: " + result3);

        float result3_v2 = MyProgram.Division(100, 5);
        Console.WriteLine("Final result: " + result3_v2);

    }
}



// Without resolution with the square & the readline to float parser;
namespace MethodPractice
{
    class MyMethods
    {
        public float square(float n1)
        {
            float result = n1 * n1;
            return result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMethods myProgram = new MyMethods();

            Console.WriteLine("escribe el numero que deseas elevar al cuadrado:");
            float Number = float.Parse(Console.ReadLine());
            float resultado = myProgram.square(Number);
            Console.WriteLine("el cuadrado de " + Number + " es: " + resultado);
        }
    }
}