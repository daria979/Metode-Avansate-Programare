using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Grafuri
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader load = new StreamReader(@"..\..\data.in");
            int n = int.Parse(load.ReadLine());
            int[,] ma = new int[n, n];
            //asigurati-va ca ma are valori 0

            string buffer;
            while ((buffer = load.ReadLine()) != null)
            {
                string[] local_data = buffer.Split(' ');
                int x = int.Parse(local_data[0]);
                int y = int.Parse(local_data[1]);

                ma[x - 1, y - 1] = 1;
                ma[y - 1, x - 1] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(ma[i, j] + " ");
                Console.WriteLine();
            }

            bool hasIsland = false;
            for (int i = 0; i < n; i++)
            {
                bool local = true;
                for (int j = 0; j < n; j++)
                    if (ma[i, j] == 1)
                    {
                        local = false;
                        break;
                    }

                if (local)
                {
                    hasIsland = true;
                    break;
                }
            }
            if (hasIsland)
                Console.WriteLine("islands : DA");
            else
                Console.WriteLine("islands : NU");


            bool hasgimpar = false;
            if (hasIsland)
                Console.WriteLine("eulerian : NU");
            else
            {

                bool isEulerian = true;
                int nrnimp = 0;
                for (int i = 0; i < n; i++)
                {
                    int sum = 0;
                    for (int j = 0; j < n; j++)
                        sum += ma[i, j];
                    if ((sum % 2) == 1)
                    {
                        nrnimp++;
                        hasgimpar = true;
                        if (nrnimp > 2)
                        {
                            isEulerian = false;
                            break;
                        }
                    }
                }
                if (isEulerian)
                    Console.WriteLine("eulerian : DA");
                else
                    Console.WriteLine("eulerian : NU");
            }

            if (!hasgimpar)
                Console.WriteLine("eulerian cycle detected");

            Console.ReadKey();
        }
    }
}
