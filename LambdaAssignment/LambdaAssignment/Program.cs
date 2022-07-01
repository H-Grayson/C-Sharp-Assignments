using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            List<string> firstNames = new List<string>() { "Hunter", "Thomas", "Leeroy", "Susan", "Beth", "Joe", "Brad", "Joe", "Pam", "Josh" }; //In the Main() method, create a list of at least 10 employees. 2 named joe
            List<string> lastNames = new List<string>() { "Arati", "Tirto", "Jenkins", "Adah", "Baldovino", "Cristian", "Rusul", "Idalia", "Fortuna", "Martina" };
            List<int> idNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> idIndex = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int index in idIndex)
            {
                Employee empInfo = new Employee();
                empInfo.firstName = firstNames[index];
                empInfo.lastName = lastNames[index];
                empInfo.id = idNumber[index];
                employees.Add(empInfo);
            }
            Console.WriteLine("The employees with the first name Joe are: \n");
            foreach (Employee employee in employees.FindAll(i => i.firstName == "Joe")) // Using a foreach loop, create a new list of all employees with the first name “Joe” with a lambda expression.
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName);
            }
            Console.WriteLine("\nThe employees with an ID greater than 5 : \n"); // Using a lambda expression, make a list of all employees with an Id number greater than 5.
            foreach (Employee employee in employees.FindAll(o => o.id >= 5))
            {
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.id);
            }
            //Console.WriteLine("\nThe employees with the first name Joe are: \n"); // Using a foreach loop, create a new list of all employees with the first name “Joe”. 
            //foreach (Employee employee in employees)
            //{
            //    if (employee.firstName == "Joe")
            //    {
            //        Console.WriteLine(employee.firstName + " " + employee.lastName);
            //    }
            //}
            //Console.ReadLine();
        }
    }
}
