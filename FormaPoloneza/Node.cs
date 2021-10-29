using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormaPoloneza
{
	public class Node
	{
		public char Info { get; set; }

		public Node (char info)
		{
			Info = info;
		}

		public static implicit operator char(Node n) => n.Info;

		public static implicit operator string(Node n) => n.Info.ToString();

		public override string ToString() => Info.ToString();


		public string View()
		{
			return Info.ToString();
		}

		public static bool operator <(Node node1, Node node2)
		{
			return node1.Info < node2.Info;
		}

		public static bool operator >(Node node1, Node node2)
		{
			return node1.Info > node2.Info;
		}

		public static bool operator <=(Node node1, Node node2)
		{
			return node1.Info <= node2.Info;
		}

		public static bool operator >=(Node node1, Node node2)
		{
			return node1.Info >= node2.Info;
		}
	}
}
