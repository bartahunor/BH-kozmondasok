using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BH_kozmondasok
{
    internal class Program
    {
        static void egyes(List<string> bevitt)
        {
            Console.WriteLine($"A fájlnak {bevitt.Count} db sorja van");
        }

        static void kettes(List<string> bevitt)
        {
            int[] szamok = new int[bevitt.Count];
            //List<int> hosszak = new List<int>();
            for (int i = 0; i < bevitt.Count; i++)
            {
                //hosszak.Add(bevitt[i].Length);
                szamok[i] = bevitt[i].Length;
            }

            int max = 0;
            int maxi = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > max) { max = szamok[i]; maxi = i; }
            }
            Console.WriteLine($"A leghosszabb sor: {bevitt[maxi]}");
        }

        static void harmas(List<string> bevitt, List<string> bevitt2)
        {
            List<string> ossz = bevitt.Concat(bevitt2).ToList();
            Console.WriteLine("Az összesített állomány elkészült");
            /*for (int i = 0; i < ossz.Count; i++)
            {
                Console.WriteLine(ossz[i]);
            }*/
        }

        static void negyes(List<string> bevitt, List<string> bevitt2)
        {
            //6
            StreamWriter ki = new StreamWriter("kozmondasok.txt");
            ki.WriteLine("-------------------------");
            ki.WriteLine("Egyesített és rendezett adatok");
            ki.WriteLine("-------------------------");

            List<string> ossz = bevitt.Concat(bevitt2).ToList();
            ossz.Sort();
            for (int i = 0; i < ossz.Count; i++)
            {
                Console.WriteLine(ossz[i]);
                ki.WriteLine(ossz[i]);
            }
            ki.Close();
        }

        static void otos(List<string> bevitt, List<string> bevitt2)
        {
            List<string> ossz = bevitt.Concat(bevitt2).ToList();
            int nemkoz = 0;
            for (int i = 0; i < ossz.Count; i++)
            {
                for (int j = 0; j < ossz[i].Length; j++)
                {
                    if (ossz[i][j] != ' ' || ossz[i][j] != ',') { nemkoz++; }
                }
            }
            Console.WriteLine($"{nemkoz}db karakter van, ami nem szóköz");
        }


        static void Main(string[] args)
        {
            /*
            BH_kozmondasok
            BH - 2025.01.28.
            */
            string fejlec = "BH_kozmondasok";
            Console.WriteLine(fejlec);
            for (int i = 0; i < fejlec.Length; i++) Console.Write("-");
            Console.WriteLine();

            List<string> szov1 = new List<string>();
            string sor;
            StreamReader be = new StreamReader("szoveg1.txt");
            sor = be.ReadLine();
            while (sor != null)
            {
                szov1.Add(sor);
                sor = be.ReadLine();
            }
            be.Close();

            List<string> szov2 = new List<string>();
            string sor2;
            StreamReader be2 = new StreamReader("szoveg2.txt");
            sor2 = be2.ReadLine();
            while (sor2 != null)
            {
                szov2.Add(sor2);
                sor2 = be2.ReadLine();
            }
            be2.Close();

            //1
            Console.WriteLine("1. feladat");
            egyes(szov1);
            egyes(szov2);
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //2
            Console.WriteLine("2. feladat");
            kettes(szov1);
            kettes(szov2);
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //3
            Console.WriteLine("3. feladat");
            harmas(szov1, szov2);
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //4
            Console.WriteLine("4. feladat");
            negyes(szov1, szov2);
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //5
            Console.WriteLine("5. feladat");
            otos(szov1, szov2);
            Console.WriteLine();
            Console.WriteLine("-------------------------");

            //6
            Console.WriteLine("6. feladat");
            Console.WriteLine("File elkészítve");
            Console.WriteLine();
            Console.WriteLine("-------------------------");







            Console.WriteLine("Kilépéshez nyomja meg az ENTER billentyűt!");
            Console.ReadLine();

        }
    }
}
