﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURS_2_Coada_Stiva
{
    class Stack
    {
        int[] values;
        char[] operanzi = { '+', '-', '/', '*' };
        public Stack()
        {
            values = new int[0];
        }

        public void Push(int ValuesToAdd)
        {
            int[] temp = new int[values.Length + 1];
            for(int i=0;i<values.Length;i++)
            {
                temp[i + 1] = values[i];
            }
            temp[0] = ValuesToAdd;
            values = temp;
        }

        public int Pop()
        {
            int toReturn = values[values.Length - 1];
            int[] temp = new int[values.Length - 1];
            for(int i=0;i<values.Length-1;i++)
            {
                temp[i] = values[i + 1];
            }
            values = temp;
            return toReturn;
        }

        public void View()
        {
            foreach (int value in values)
            {
                Console.Write(value + " ");
            }
        }
    }
}
