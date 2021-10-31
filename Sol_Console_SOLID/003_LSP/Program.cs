using _003_LSP_Library;
using System;

namespace _003_LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager accountingVP = new Manager();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);

            // Employee emp = new Employee();
            // Employee emp = new Manager();
            Employee emp = new CEO();  //Con este da error, CEO no tiene manager.

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary}/hour."); 
            
            Console.ReadLine();
        }
    }
}
