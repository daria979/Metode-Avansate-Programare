using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS_2_Coada_Stiva
{
    class Program
    {
        static void Queue()
        {
            Queue myqueue = new Queue();

            Console.Write("Type the queue lenght: ");
            int queue_lenght = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insert elements of the queue: ");
            string s = Console.ReadLine();
            string[] values = s.Split(' ');

            for (int i = 0; i < queue_lenght; i++)
            {
                int number = int.Parse(values[i]);
                myqueue.Push(number);
            }


            Console.Write("The queue is: ");
            myqueue.View();

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
                    myqueue.Push(new_element);
                    Console.Write("*** New queue *** ");
                    myqueue.View();
                }
                if (action == 0)
                {
                    myqueue.Pop();
                    Console.Write("*** New queue *** ");
                    myqueue.View();
                }
                Console.WriteLine(" ");
            } while (action == 1 || action == 0);
        }
        static void Main(string[] args)
        {
            Queue();
        }
    }
}
