using System;

namespace Proyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10] { "Pedro", "Robert", "Joan", "Selena", "Mike", "Dani", "Platz", "i", "Celis", "" };
            int arrayCurrentIndex = 9;
            bool userType;

            Console.WriteLine("Hola bienvenido a mi Restaurante!");
            while (arrayCurrentIndex < 10)
            {
                Console.WriteLine("\n \nEstas registrado? Escribe true, o Escribe false to para registrarte");
                userType = Convert.ToBoolean(Console.ReadLine());
                if (userType == true)
                {
                    Console.WriteLine("Hola! Estas registrado, ingresa tu nombre para buscarlo");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("Localizado eres  {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if (index == -1)
                    {
                        Console.WriteLine("Tu usuario no ha sido encontrado, intenta de nuevo o registrate!");
                    }
                    else
                    {
                        Console.WriteLine("Bienvenido {0}, Es un placer atenderlo", userNames[index]);
                    }
                }
                else if (userType == false)
                {
                    Console.WriteLine("Por favor escriba y recuerde su nombre de usuario");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Has sido registrado exitosamente\n" +
                        "Tu nombre de usuario es -> {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("El restaurante está lleno:");
            int auxIndex = 0;
            foreach (string element in userNames)
            {
                Console.WriteLine("Numero: {0} Usuario:{1}", auxIndex + 1, userNames[auxIndex]);
                auxIndex++;
            }
            Environment.Exit(0);
        }
    }
}
