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

            //9. Készíts programot, ami megszámolja egy beolvasott stringben pl. az "a" betűket.
            Console.Write("Kérem adjon meg egy szövegrészt: ");
            string szovegresz = Console.ReadLine();
            int szamlalo = 0; //Összegzés törvénye
            //char karakter = '=';
            for (int i = 0;i<szovegresz.Length;i++)
            {
                if (szovegresz[i] == 'a')
                {
                    szamlalo++;
                }
            }
            Console.WriteLine($"A {szovegresz} - ben az \"a\" betűk száma: {szamlalo}");

            //10. Olvasd be az ax2+bx+c=0 egyenlet együtthatóit, majd írd ki az egyenlet megoldásait!
            //1.lépés az együtthatók bekérése
            Console.Write("Kérem adja meg az egyenlet \"a\" együtthatóját! ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az egyenlet \"b\" együtthatóját! ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg az egyenlet \"c\" együtthatóját! ");
            int c = int.Parse(Console.ReadLine());
            int reszeredmeny = b  *  b  -  4  *  a  *  c;
            if (reszeredmeny<0)
            {
                Console.WriteLine("Az egyenletnek nincs megoldása");
            }
            if (reszeredmeny==0)
            {
                double egybeeso = -b/2*a;
                Console.WriteLine($"Az egyenletnek 2 egybeeső gyöke van melynek értéke: {egybeeso}");
            }
            if (reszeredmeny>0)
            {
                double egyik = (-b + Math.Sqrt(reszeredmeny)) / 2 * a;
                double masik = (-b - Math.Sqrt(reszeredmeny)) / 2 * a;
                Console.WriteLine($"Az eredmények: \nx1={egyik} \nx2={masik}");
            }

            //11. Írj programot, amely beolvas egy egész számot, majd elosztja 2-vel annyiszor,
            //ahányszor lehet és közben felírja a számot a kettes számok  
            //szorzataként megszorozva egy olyan számmal, amely már nem osztható 2-vel. Például: 120=2*2*2*15, 17=17
            Console.ReadKey();
        }
    }
}
