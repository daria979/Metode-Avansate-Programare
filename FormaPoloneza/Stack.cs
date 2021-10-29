using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPoloneza
{
        public class Stack
        {
            #region Members
            private Node[] values;
            private int count;
            #endregion

            #region Constructor
            public Stack()
            {
                count = 0;
                values = new Node[count];
            }
            #endregion

            #region Methods
            public void Add(Node newNode)
            {
                Node[] newValues = new Node[count + 1];
                for (int i = 0; i < count; i++)
                {
                    newValues[i] = values[i];
                }
                newValues[count] = newNode;
                values = newValues;
                count++;
            }

            public Node Pop()
            {
                if (count == 0) return null;
                count--;
                Node extractedValue = values[count];
                Node[] newValues = new Node[count];
                for (int i = 0; i < count; i++)
                {
                    newValues[i] = values[i];
                }
                values = newValues;
                return extractedValue;
            }

            public string View()
            {
                string s = "";
                for (int i = 0; i < count; i++)
                {
                    s += values[i].View() + ", ";
                }
                return s;
            }
            #endregion
        }
    }

