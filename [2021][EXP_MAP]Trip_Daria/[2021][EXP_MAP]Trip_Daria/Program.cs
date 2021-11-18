using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2021__EXP_MAP_Trip_Daria
{
    class Program
    {
        static bool is_prime_number(int value)
        {
            int number = value;
            int is_prime = 0;
            for (int i = 2; i <= value/2; i++)
            {
                if (value % i == 0)
                {
                    is_prime = 1;
                    break;
                }
            }
            if (is_prime == 0)
                return true;
            return false;
        }

        static int digits_sum(int value)
        {
            int Sum = 0;
            while (value > 0)
            {
                Sum = Sum + value % 10;
                value = value / 10;
            }
            return Sum;
        }
        static void Main(string[] args)
        {

            string path = @"C:\Users\Daria\Source\Repos\Metode-Avansate-Programare\[2021][EXP_MAP]Trip_Daria\[2021][EXP_MAP]Trip_Daria\data01.in";
            string[] lines = File.ReadAllLines(path);

            int n = int.Parse(lines[0]);

            Console.WriteLine("n este: " + n);

            int[] numbers= new int[n];

            int k = 1;
            for(int i=0;i<n;i++)
            {
                int x = Int32.Parse(lines[k]);
                numbers[i] = x;
                Console.WriteLine("Number from file: " + numbers[i]);
                k++;
            }

               

            int[] output = new int[2*n];
            int pos = 0;
            for(int i=0;i<n;i++)
            {
                output[pos] = numbers[i];
                if (is_prime_number(numbers[i]))
                {
                    pos++;
                    output[pos] = digits_sum(numbers[i]);

                }
                pos++;
            }

            Console.WriteLine();
            Console.WriteLine("output:");
            
            for(int i=0;i<pos;i++)
            {
                Console.Write(output[i] + " ");
            }
        }
    }
}
