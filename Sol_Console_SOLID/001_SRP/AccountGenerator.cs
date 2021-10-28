using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SRP
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person user)
        {
            // Crear un nombre de usuario para la persona.
            Console.WriteLine($"Su nombre de usuario es {user.FirstName.Substring(0, 1) }{ user.LastName }");
        }
    }
}
