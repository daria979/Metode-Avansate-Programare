using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication14
{
    public class Stack : Tube
    {
        
        public Stack() : base() 
        {
        }

        public void Push (int x)
        {
            addbeg(x);
        }

        public int Pop()
        {
            return delbeg();
        }

        public override void view()
        {
            Console.Write("Stack : ");
            base.view();
        }
    }


}
