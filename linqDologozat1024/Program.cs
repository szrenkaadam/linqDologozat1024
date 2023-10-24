using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Channels;

namespace linqDologozat1024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bolygok = new List<Bolygo>();

            using (var sr = new StreamReader(path: @"..\..\src\solsys.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    bolygok.Add(new Bolygo(sr.ReadLine()));
                }
            }
            //1. feladat
            Console.WriteLine($"{bolygok.Count} bolygó van a naprendszerben");

            //2. feladat
            var f2 = bolygok.Average(a => a.HoldakSzama);
            Console.WriteLine($"A holdak számának átlaga: {f2}");
            //3. fleadat
            var f3 = bolygok.OrderBy(b => b.TerfArany).Last();
            Console.WriteLine($"A legnagyobb bolygó a {f3}");
            //4. feladat
            Console.WriteLine("Adj meg egy bolygó nevet: ");
            string bekertNev = Console.ReadLine();

            for (int i = 0; i < bolygok.Count; i++)
            {
                if (bekertNev == bolygok[i].Nev)
                {
                    Console.WriteLine("Van ilyen bolygó a listán");
                }
                else
                    Console.WriteLine("Nincs ilyen bolygó a listán");
            }
            Console.WriteLine("Adj meg egy számot: ");
            int megadottSzam = Console.ReadLine();

            //5.
            int nagyobb = new List<int>();
            for (int i = 0; i < bolygok.Count; i++)
            {
                if (bolygok[i].HoldakSzama >= megadottSzam)
                {
                    nagyobb.Add(bolygok[i]);
                }
            }


        }

    }

}