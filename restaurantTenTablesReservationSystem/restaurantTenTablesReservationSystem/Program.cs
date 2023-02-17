

using System;

///
// *1: Validar si el usuario existe, caso contrario sing up;
// *2: Dar bienvenida a usuario;
// *3: Loop for 'till signed 10 users;
///

namespace NameSpace
{
    class ThisIsMeTheClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Running... ");
            System.Threading.Thread.Sleep(1000);

            string[] userNames = new string[10] {
                "Mr. Person",
                "pedro",
                "rober",
                "",
                "",
                "",
                "",
                "",
                "",
                "" };

            // know the position to save new users(number);
            int arrayCurrentIndex = 1;

            Console.WriteLine("u' want to sign in? True yes or False no");
            bool decision = Convert.ToBoolean(Console.ReadLine());

                if (decision == true)
                {
                    Console.WriteLine("Hola usuario");
                    string userToSearch = Console.ReadLine();

                    Console.WriteLine("Searching user... " + userToSearch);

                // Method who searchs arrays;
                // first parameter(Array to search);
                // second parameter(which user is search);
                    int index = Array.IndexOf(userNames, userToSearch);

                    if (index == -1)
                    {
                        Console.WriteLine("User not found. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("Welcome to " + userNames[index] + " page's");
                    }
                }
                else if (decision == false)
                {
                if (arrayCurrentIndex == 10)
                {
                    Console.WriteLine("the restaurant is full. try again next year");

                    //    // close graphic interface;
                    //    // código de salida 0 en parametro de exit();
                    Environment.Exit(0);
                    //}

                    // por cada cadena de elemento en username, hacer...;
                    foreach (string element in userNames)
                    {
                        int auxIndex = 0;
                        Console.WriteLine($"User number {0} and user name: {1}", auxIndex, userNames[auxIndex]);

                    }

                }
                else if (arrayCurrentIndex < 10)
                {
                    Console.WriteLine("Please write and remember your username:");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("\n");

                    Console.WriteLine("Please write your new password:");
                    string newPassword = Console.ReadLine();
                    Console.WriteLine("\n");


                    Console.WriteLine($"Your user has been saved successfully\n" + "Your username is: {0}", userNames[arrayCurrentIndex]);
                    // arrayCurrentIndex++;


                    Console.WriteLine("Introduzca el nombre de usuario: ");
                    string userSignUp = Console.ReadLine();

                    Console.WriteLine("Introduzca la contraseña:");
                    string passSignUp = Console.ReadLine();

                    if (userSignUp == userNames[arrayCurrentIndex] && passSignUp == newPassword)
                    {

                        Console.WriteLine("Searching user... " + userSignUp);

                        System.Threading.Thread.Sleep(3000);

                        Console.WriteLine($"Hola usuario {userNames[arrayCurrentIndex]}");

                        Console.WriteLine($"Your user ID is: {arrayCurrentIndex}. Be quiet");

                    }
                    else if (userSignUp == "" || passSignUp == "")
                    {
                        Console.WriteLine("Error con el inicio de sesión. Try again");
                    }
                    else
                    {
                        Console.WriteLine("Que onda crack, que hiciste");
                    }
                }
                else
                {
                    Console.WriteLine("Error trying to sign up u'");
                }
                    }
                }
            }
        }