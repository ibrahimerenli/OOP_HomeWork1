using System;
using System.Collections.Generic;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kare kare = new Kare(15);
            Daire daire = new Daire(10);
            Dikdortgen dikdortgen = new Dikdortgen(12, 20);
            List<Sekil> sekiller = new List<Sekil>();
            sekiller.Add(kare);
            sekiller.Add(daire);
            sekiller.Add(dikdortgen);
            foreach (var sekil in sekiller)
            {
                sekil.yazdir();
            }

            if(kare.dikdortgeneSigar(dikdortgen) == true)
                Console.WriteLine("kare, dikdörtgene sıgar.");
            else
                Console.WriteLine("kare, dikdörtgene sıgmaz.");

            if (daire.kareyeSigar(kare) == true)
                Console.WriteLine("daire, kareye sıgar.");
            else
                Console.WriteLine("daire, kareye sıgmaz.");
           
        }

    }
}

