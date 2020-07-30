using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._07._30
{
    class Program
    {
        static void Main(string[] args)
        {
            //7. Készíts programot, amely bekér egy szöveget, 
            //majd képernyőre írja a szöveget megfordítva, vagyis a betűk fordított sorrendjében!
            //Mit használunk itt ki: azt, hogy a szöveg az egyben karaktertömb is!
            string szoveg = "VALAKI";
            for (int i = szoveg.Length-1;i>=0;i=i-1)
            {
                Console.Write($"{szoveg[i]}");
            }
            Console.WriteLine();//üres sor beszúrása!
            //2.féle megoldás
            for (int i = szoveg.Length - 1; i >= 0; i = i - 1)
            {
                
                Console.Write($"{szoveg.Substring(i,1)}");
            }
            Console.WriteLine();
            //3.féle
            char[] kar_tomb = szoveg.ToCharArray();
            for (int i = kar_tomb.Length - 1; i >= 0; i = i - 1)
            {
                Console.Write($"{kar_tomb[i]}");
                Console.Write($"{szoveg.Substring(i, 1)}");
            }

            //8. Készíts programot, ami kiírja egy beolvasott string karaktereit szóközökkel elválasztva
            Console.WriteLine();
            string szo = "valami";
            for (int i = 0; i <= 5;i++)
            {
                if (i == szo.Length -1)
                {
                    Console.Write($"{szo[i]}");
                }
                else
                {
                    Console.Write($"{szo[i]} ");
                }               
                //Console.Write($" ");
            }
            Console.ReadKey();
        }
    }
}
