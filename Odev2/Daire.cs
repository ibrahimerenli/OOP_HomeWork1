using System;
using System.Collections.Generic;
using System.Text;


namespace Odev2
{
    class Daire : Sekil
    {
        public double YariCap;
        public double yariCap {
            get
            {
                return YariCap;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(YariCap)} >= 0 olmalıdır!");
                }
                YariCap = value;
            }
        }
        public Daire(double Yaricap) { yariCap = Yaricap; }
        public bool kareyeSigar(Kare kare)
        {

            if (kare.kenarUzunlugu > yariCap)
                return true;
            else
                return false;
        }

        public override double getAlan()
        {

            return Math.PI * Math.Pow(yariCap, 2);
        }

        public override double getCevre()
        {

            return 2 * Math.PI * yariCap;
        }

        public override void yazdir()
        {
            Console.WriteLine("Dairenin yarıçapı: " + this.yariCap);
            Console.WriteLine("Dairenin alanı: " + this.getAlan());
            Console.WriteLine("Dairenin çevresi: " + this.getCevre() + "\n");

        }
    }
}
