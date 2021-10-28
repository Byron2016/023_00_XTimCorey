using System;

namespace _001_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Crear un nombre de usuario para la persona.
            Console.WriteLine($"Su nombre de usuario es {user.FirstName.Substring(0,1) }{ user.LastName }");
            StandardMessages.EndApplication();
        }
    }
}
