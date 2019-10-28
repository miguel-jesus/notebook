using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_list
{
    class Program
    {
        static string line, command, parameters;
        static List<string> todoList = new List<string>();
        static int indexOfFisrtWhitespace = 0;
        static void Main(string[] args)
        {
            // Ask the user to choose an option.
            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\t1 - Add");
            Console.WriteLine("\t2 - Print");
            Console.WriteLine("\t3 - PrintAll");
            Console.WriteLine("\t4 - Done ");
            Console.WriteLine("\t5 - ReOrder <item nr> <desired position>  ");
            Console.WriteLine("\t6 - Quit ");

            Console.ReadKey();

            do
            {   
                line = Console.ReadLine();
                try
                {
                    indexOfFisrtWhitespace = line.IndexOf(' ');
                    command = line.Substring(0, indexOfFisrtWhitespace);

                }
                catch (IndexOutOfRangeException ex)
                {
                    command = line;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    command = line;
                }

                switch (command)
                {
                    case "1":
                        parameters = line.Substring(indexOfFisrtWhitespace + 1);
                        Add(parameters);
                        break;
                    case "2":
                        Print();
                        break;
                    case "3":
                        //Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                        break;
                    case "4":
                        parameters = line.Substring(indexOfFisrtWhitespace + 1);
                        int numTarea = Int32.Parse(parameters) - 1;
                        Done(numTarea);
                        break;
                    case "5":
                        ReOrder();
                        break;
                }


            } while(command != "6");

        }
        public static void Add(String task)
        {
            todoList.Add(task);
            Console.WriteLine();
            Console.WriteLine("\t" + task + " the new task has been added to ToDo list at position " + todoList.Count);
            Console.WriteLine();
        }
         public static void Print()
        {
            Console.WriteLine();
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"\t{i + 1}: " + todoList[i]);
                if (i == 2) break;
            }
            Console.WriteLine();
        }

        public static void Done(int task)
        {
            Console.WriteLine(todoList.ElementAt(task)+" has been finished" ) ;
            todoList.RemoveAt(task);
            
        }
        public static void ReOrder()
        {
            todoList.Reverse(0,1);
        }
        
    }
}
