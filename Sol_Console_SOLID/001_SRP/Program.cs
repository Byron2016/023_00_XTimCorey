using System;

namespace _001_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            // Chequear que nombre y apellido son válidos.
            if (string.IsNullOrEmpty(user.FirstName))
            {
                Console.WriteLine("No ha proporcionado un nombre inválido!");
                StandardMessages.EndApplication();
                return;
            }

            if (string.IsNullOrEmpty(user.LastName))
            {
                Console.WriteLine("No ha proporcionado un apellido inválido!");
                StandardMessages.EndApplication();
                return;
            }

            // Crear un nombre de usuario para la persona.
            Console.WriteLine($"Su nombre de usuario es {user.FirstName.Substring(0,1) }{ user.LastName }");
            StandardMessages.EndApplication();



        }
    }
}
