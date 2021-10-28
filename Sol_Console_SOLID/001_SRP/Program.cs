using System;

namespace _001_SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ahora Main tiene una sola razón y es controlar el
            //flujo de la aplicacion.

            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.CreateAccount(user);
            StandardMessages.EndApplication();
        }
    }
}
