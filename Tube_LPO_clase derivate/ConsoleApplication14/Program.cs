using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Tube A = new Tube ();
            A.addbeg(1);
            A.addbeg(2);
            A.addbeg(3);
            A.addbeg(4);
            A.addend(5);
            A.addend(6);
            A.addend(7);
            A.delend();
            
            A.view();
            A.delend();
            A.view();
            A.delbeg();
            A.view();
            */
            /*
            Stack B = new Stack();
            B.Push(1);
            B.Push(2);
            B.Push(3);
            B.Push(4);
            B.Pop();
            B.view();
            */

            LPO lpo = new LPO();
            lpo.Push(10);
            lpo.Push(12);
            lpo.Push(7);
            lpo.Push(13);
            lpo.Push(7);
            lpo.Push(1);
            lpo.Push(11);
            lpo.Push(11);
            lpo.Push(5);
            lpo.Push(2);
            lpo.Push(2);
            lpo.Push(1);
            lpo.Push(0);

            lpo.Pop(5);
            lpo.Pop(2);
            lpo.Pop(2);
            lpo.Pop(2);

            lpo.view();

            Console.ReadKey();
        }
    }
}
