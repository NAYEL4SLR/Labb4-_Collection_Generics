using System;
using System.Collections;

namespace Labb4__Collection_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee_1 = new Employee("0001", "Nael Sharabi", "Male", 30000);
            Employee employee_2 = new Employee("0002", "Gillian Brown", "Female", 25000);
            Employee employee_3 = new Employee("0003", "Robin Svensson", "Male", 35000);
            Employee employee_4 = new Employee("0004", "Hans Steiner", "Male", 29000);
            Employee employee_5 = new Employee("0005", "Mike Jefferson", "Male", 23000);

            Stack stack = new Stack();
            stack.Push(employee_1);
            stack.Push(employee_2);
            stack.Push(employee_3);
            stack.Push(employee_4);
            stack.Push(employee_5);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
