
using System;

namespace NameSpaceName
{
    class ClassName
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Running...");

            

            for (int i = 0; 0 < 1000; i++)
            {
                ///System.Threading.Thread.Sleep(3000);
                ///
                Console.WriteLine("\nQue quéres tomar hoy?\n");

                string respuesta = Console.ReadLine();

                switch (respuesta)
                {
                    case "coca-cola" or "coca" or "coca cola" or "Coca Cola" or "Coca cola":
                        Console.WriteLine("\nElegiste " + respuesta + ". U$D3");
                        break;

                    case "lima" or "lima limon":
                        Console.WriteLine("\nElegiste " + respuesta + ". U$D2,5");
                        break;

                    case "soda":
                        Console.WriteLine("\nElegiste " + respuesta + ". U$D5");
                        break;
                    default:
                        if (respuesta == "" || respuesta == "nada" || respuesta == "nada mas")
                        {
                            Console.WriteLine("\nAdios!\n");
                            /// i = 1000;
                            /// need to know how to close the debug task when I want nothing;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nQue pena bro. No tenemos mas " + respuesta);
                            break;
                        }
                }
            }

            // Console.WriteLine("Ultimos pedidos");
            // Console.WriteLine(respuesta);


        }
    }
}