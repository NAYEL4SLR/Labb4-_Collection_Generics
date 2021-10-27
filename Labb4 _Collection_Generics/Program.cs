using System;
using System.Collections;
using System.Collections.Generic;

namespace Labb4__Collection_Generics
{
    class Program
    {
        static void Main(string[] args)
        {   // Part 1

            Console.SetWindowSize(85, 85);
            Stack stack = new Stack();
            AddToStack(stack);
            PrintOutStackItems(stack);
            PopInStack(stack);
            PeekInStack(stack);
            SearchItemInStack(stack, "0003");

            // Part 2 

            List<Employee> list = new List<Employee>();
            AddToList(stack, list);
            CheckIfContains(list, "0002");
            Console.WriteLine(list.Find(e => e.ReturnGender() == "Male")+"\n\n");
            FindAndPrintFromList(list, "Male");
            Console.ReadLine();
        }
        static void AddToStack(Stack stack)
        {
            stack.Push(new Employee("0001", "Nael Sharabi", "Male", 30000));
            stack.Push(new Employee("0002", "Gillian Brown", "Female", 25000));
            stack.Push(new Employee("0003", "Robin Svensson", "Male", 35000));
            stack.Push(new Employee("0004", "Hans Steiner", "Male", 29000));
            stack.Push(new Employee("0005", "Mike Jefferson", "Male", 23000));
        }
        static void PrintOutStackItems(Stack stack)
        {
            foreach (Employee employee in stack)
            {
                Console.WriteLine("   Items left in the stack = " + stack.Count);
                Console.WriteLine(employee);
            }
            Console.WriteLine($"\n__________________________________________" +
                $"_______________________________________\n\n");
        }
        static void PopInStack(Stack stack)
        {
            Console.WriteLine("Retrive using Pop method\n");
            while (stack.Count != 0)
            {
                Console.WriteLine(stack.Pop());
                Console.WriteLine("   Items left in the stack = " + stack.Count);
            }
            Console.WriteLine($"\n__________________________________________" +
                $"_______________________________________\n\n");
            AddToStack(stack);
        }
        static void PeekInStack(Stack stack)
        {
            Console.WriteLine("Retrive using Peek method\n");
            while (stack.Count != 0)
            {
                Console.WriteLine("   Items left in the stack = " + stack.Count);
                Console.WriteLine(stack.Peek());
                stack.Pop();

            }
            Console.WriteLine($"\n__________________________________________" +
                $"_______________________________________\n\n");
            AddToStack(stack);
        }
        static void SearchItemInStack(Stack stack ,string item)
        {
            foreach (Employee employee in stack)
            {
                if (employee.ToString().Contains(item))
                {
                    Console.WriteLine($"  '{item}' is in the stack " +
                        $"which has the following info:  \n\n{employee}");
                }
            }
            Console.WriteLine($"\n__________________________________________" +
              $"_______________________________________\n\n");
        }
        static void AddToList(Stack stack, List<Employee> list)
        {
            foreach (Employee employee in stack)
            {
                list.Add(employee);
            }
        }
        static void CheckIfContains(List<Employee> list, string ID_Num)
        {
            if (list.Contains(list.Find(e => e.ReturnID() == "0002")))    //Applying list.Contains()
            {
                Console.WriteLine($"\tThe Employee with the number: {ID_Num}" +
                    $" was found in the list in\n\n" +
                    $"{list.Find(e => e.ReturnID() == "0002")}");
            }
            else
            {
                Console.WriteLine($"\t{ID_Num} was not found in the list\n");
            }
            Console.WriteLine($"\n__________________________________________" +
              $"_______________________________________\n\n");
        }
        static void FindAndPrintFromList(List<Employee> list, string gender)
        {
            Console.WriteLine("\t Employees that are {0}\n", gender);
            var found = list.FindAll(item => item.ReturnGender() == gender);
            foreach (Employee item in found)
            {
                Console.WriteLine(item);
            }
        }
    }
}
