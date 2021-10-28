using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SRP
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Bienvenido a mi aplicación");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Presione enter para cerrar...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fielName)
        {
            Console.WriteLine($"No ha proporcionado un {fielName} válido!");
        }
    }
}
