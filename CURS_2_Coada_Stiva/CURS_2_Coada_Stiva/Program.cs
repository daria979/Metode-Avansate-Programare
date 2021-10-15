using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS_2_Coada_Stiva
{
    class Program
    {
        static void DataType1(string data)
        {
            
            Queue queue = new Queue();
            
            Console.Write("Type the lenght of the queue: ");
            int queue_lenght = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert elements of the queue: ");
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            for (int i = 0; i < queue_lenght; i++)
            {
                int number = int.Parse(values[i]);
                queue.Push(number);
            }


            Console.Write("The queue is: ");
            queue.View();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Type '1' to add new elements.\nType '0' to delete elements." +
                "\n----- To end the process type any other key. -----");

            Console.WriteLine();
            Console.WriteLine();

            int action;
            do
            {
                Console.Write("Instruction: ");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    Console.Write("Insert the new element: ");
                    int new_element = Convert.ToInt32(Console.ReadLine());
                    queue.Push(new_element);
                    Console.Write("*** New queue *** ");
                    queue.View();
                }
                if (action == 0)
                {
                    queue.Pop();
                    Console.Write("*** New queue *** ");
                    queue.View();
                }
                Console.WriteLine(" ");
            } while (action == 1 || action == 0);
        }

        static void DataType2(string data)
        {

            Stack stack = new Stack();

            Console.Write("Type the lenghtof the queue: ");
            int queue_lenght = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert elements of the queue: ");
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            for (int i = 0; i < queue_lenght; i++)
            {
                int number = int.Parse(values[i]);
                stack.Push(number);
            }


            Console.Write("The queue is: ");
            stack.View();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Type '1' to add new elements.\nType '0' to delete elements." +
                "\n----- To end the process type any other key. -----");

            Console.WriteLine();
            Console.WriteLine();

            int action;
            do
            {
                Console.Write("Instruction: ");
                action = Convert.ToInt32(Console.ReadLine());
                if (action == 1)
                {
                    Console.Write("Insert the new element: ");
                    int new_element = Convert.ToInt32(Console.ReadLine());
                    stack.Push(new_element);
                    Console.Write("*** New queue *** ");
                    stack.View();
                }
                if (action == 0)
                {
                    stack.Pop();
                    Console.Write("*** New queue *** ");
                    stack.View();
                }
                Console.WriteLine(" ");
            } while (action == 1 || action == 0);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("If you want to work with QUEUE type 'q'.\nIf you want to work with STACK type 's'.");
            Console.Write("Data type: ");
            char data_type = Convert.ToChar(Console.ReadLine());

            if(data_type=='q')
            {
                DataType1("queue");
            }
            if(data_type=='s')
            {
                DataType2("stack");
            }

            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
