using System;
using System.Collections;

namespace Labb4__Collection_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            AddEmployees(stack);
            int itemsLeft = stack.Count;
            PrintOutEmployees(stack);
            PopObjects(stack);
            Console.ReadLine();
        }
        static void AddEmployees(Stack stack)
        {
            stack.Push(new Employee("0001", "Nael Sharabi", "Male", 30000));
            stack.Push(new Employee("0002", "Gillian Brown", "Female", 25000));
            stack.Push(new Employee("0003", "Robin Svensson", "Male", 35000));
            stack.Push(new Employee("0004", "Hans Steiner", "Male", 29000));
            stack.Push(new Employee("0005", "Mike Jefferson", "Male", 23000));
        }
        static void PrintOutEmployees(Stack stack)
        {
            foreach (Employee item in stack)
            {
                Console.WriteLine("   Items left in the stack = " + stack.Count);
                Console.WriteLine(item);
            }
            Console.WriteLine($"____________________________________________" +
                $"___________________________________________________________");
        }
        static void PopObjects(Stack stack)
        {
            stack.Pop();

            //for (int i = 0; i < stack.Count; i++)
            //{
            //    Console.WriteLine(stack[i]);
            //}
            //Console.WriteLine("Efter\n\n");
            //foreach (var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
        }

    }
}
