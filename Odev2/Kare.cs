using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class Kare : Sekil
    {
        public double KenarUzunluğu;
        public double kenarUzunlugu 
        { 
            get 
            {
                return KenarUzunluğu;
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(KenarUzunluğu)} >= 0 olmalıdır!");
                }
                KenarUzunluğu = value;
            } 
        }
        public Kare(double KenarUzunluğu) { kenarUzunlugu = KenarUzunluğu; }

        public bool dikdortgeneSigar(Dikdortgen dikdortgen)
        {

            if (dikdortgen.kisaKenarUzunlugu >= kenarUzunlugu)
                return true;
            else
                return false;
        }
        public override double getAlan()
        {
            return Math.Pow(kenarUzunlugu, 2);
        }

        public override double getCevre()
        {
            return kenarUzunlugu * 4;
        }

        public override void yazdir()
        {
            Console.WriteLine("Karenin kenar uzunluğu: " + this.kenarUzunlugu);
            Console.WriteLine("Karenin alanı: " + this.getAlan());
            Console.WriteLine("Karenin çevresi: " + this.getCevre()+"\n");
        }
    }
}
