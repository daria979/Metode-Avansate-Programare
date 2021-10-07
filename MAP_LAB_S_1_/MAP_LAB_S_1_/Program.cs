using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MAP_LAB_S_1_
{
    /// <summary>
    /// 
    /// T E M A
    /// 
    /// Se da un fisier text care pe prima linie contine un numar natural 
    /// reprezentand numarul de varfuri ale unui graf neorientat. Iar pe urmatoarele 
    /// linii contine muchiile grafului si costurile aferente, cate un triplet pe fiecare 
    /// linie reprezentand varful initial, varful final si costul muchiei. 
    /// Scrieti un program care citeste fisierul si afiseaza matricea costurilor asociata grafului.
    /// 
    /// Matricea costurilor = pe diagonala principala si 
    /// unde nu exista muchie intre cele doua varfuri e 0, 
    /// iar unde exista muchie, valoarea matricii este costul aferent muchiei.
    /// </summary>

    class Program
    {
        /// <summary>
        /// Transformare lista muchii in matrice de adiacenta
        /// </summary>
        /// 
        static void Matrice()
        {
            //descrieti un program care citeste dintr-un
            //fisier care ale pe prima linie un numar n reprezentanrilor al unui graf,
            //iar apoi linii cu o pereche de numere pe fiecare reprezentand muc
            //
            //afisati matricea de adiacenta

            string path = "data.txt";
            string[] lines = File.ReadAllLines(path);

            int n = int.Parse(lines[0]);
            int[,] matrice = new int[n, n];
            char[] separators = { ' ', '\t', '\n' };
            for (int index = 1; index < lines.Length; index++)
            {
                int vf1 = int.Parse(lines[index].Split(separators)[0]);
                int vf2 = int.Parse(lines[index].Split(separators)[1]);

                matrice[vf1, vf2] = 1;
                matrice[vf2, vf1] = 1;
            }

            for (int i = 0; i < matrice.GetLength(0); i++)
            {
                for (int j = 0; j < matrice.GetLength(1); j++)
                {
                    Console.Write($"{matrice[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// T E M A - implementare coada
        /// </summary>
        static void Coada()
        {
           
        }
        static void Main(string[] args)
        {
            //Matrice();
            Coada();
        }
    }
}
