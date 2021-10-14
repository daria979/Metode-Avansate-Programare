using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS_2_Coada_Stiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myqueue = new Queue();

            Console.WriteLine("Type the queue lenght: ");
            int queue_lenght = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert elements of the queue:");
            for (int i=0;i<queue_lenght;i++)
            {
                int number = Convert.ToInt32(Console.ReadLine()); 
                myqueue.Push(number);
            }

            Console.WriteLine();
            myqueue.View();

            Console.WriteLine();

            Console.WriteLine("Type 1 for adding new elements \n Type 0 to delete elements." +
                "\n To end the process type any key (different from 1 or 0)");

            int action = Convert.ToInt32(Console.ReadLine());
            while(action==0 || action==1)
            {
                if(action==1)
                {
                    Console.WriteLine("Insert the new element: ");
                    int new_element = Convert.ToInt32(Console.ReadLine());
                    myqueue.Push(new_element);
                    myqueue.View();
                }
                else
                {
                    myqueue.Pop();
                    myqueue.View();
                }
            }

        }
    }
}
