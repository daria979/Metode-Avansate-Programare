using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPoloneza
{
	class Program
	{
		public static string expresie = "";
		public static int[] operanzi = null;
		public static Stack stiva = new Stack();
		public const string path = "FormaPoloneza.in";

		public static bool IsOperator(char c)
		{
			switch(c)
			{
				case '+':
				case '-':
				case '*':
				case '/':
				case '(':
				case ')':
					return true;
			}
			return false;
		}


		public static int Priority(char c)
		{
			if(c == '(' || c == ')')
			{
				return 0;
			}
			if (c == '*' || c == '/')
			{
				return 1;
			}
			if (c == '+' || c == '-')
			{
				return 2;
			}
			throw new Exception("Wrong operator!");
		}

		static void Main(string[] args)
		{
			//Console.Write("Expresie = ");
			//expresie = Console.ReadLine().Replace(" ", "");
			expresie = File.ReadAllText(path).Replace(" ", "");
			List<string> formaPoloneza = new List<string>();
			int i = 0;
			while (i < expresie.Length)
			{
				string operand = "";
				while (i < expresie.Length && !IsOperator(expresie[i]))
				{
					operand += expresie[i++];
				}
				if (operand != "")
				{
					formaPoloneza.Add(operand);
				}
				else
				{
					char operatorExpresie = expresie[i++];
					if (operatorExpresie == ')')
					{
						string operatorStiva;
						while ((operatorStiva = stiva.Pop()) != "(")
						{
							formaPoloneza.Add(operatorStiva);
						}
					}
					else
					{
						Node nodeStiva = stiva.Pop();
						if (nodeStiva == null)
						{
							stiva.Add(new Node(operatorExpresie));
						}
						else
						{
							int prioritateExpresie = Priority(operatorExpresie), prioritateStiva = Priority(nodeStiva);
							if (prioritateExpresie >= prioritateStiva && prioritateStiva > 0)
							{
								formaPoloneza.Add(nodeStiva);
								stiva.Add(new Node(operatorExpresie));
							}
							else
							{
								stiva.Add(nodeStiva);
								stiva.Add(new Node(operatorExpresie));
							}
						}
					}
				}
				if (i == expresie.Length)
				{
					Node nodeStiva;
					while ((nodeStiva = stiva.Pop()) != null)
					{
						formaPoloneza.Add(nodeStiva);
					}
				}
			}
			Console.WriteLine(expresie);
			foreach (string element in formaPoloneza)
			{
				Console.Write(element + " ");
			}
			Console.Read();
		}
	}
}
