using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    class Dikdortgen : Sekil
    {
        public double KısaKenaruzunlugu;
        public double UzunKenaruzunlugu;
        public double kisaKenarUzunlugu {
            get
            {
                return KısaKenaruzunlugu;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(KısaKenaruzunlugu)} >= 0 olmalıdır!");
                }
                KısaKenaruzunlugu = value;
            }
        }

        public double uzunKenarUzunlugu {
            get
            {
                return UzunKenaruzunlugu;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value, $"{nameof(UzunKenaruzunlugu)} >= 0 olmalıdır!");
                }
                UzunKenaruzunlugu = value;
            }
        }
        public Dikdortgen(double KisaKenarUzunlugu, double UzunKenarUzunlugu) { kisaKenarUzunlugu = KisaKenarUzunlugu; uzunKenarUzunlugu = UzunKenarUzunlugu; }
        public override double getAlan()
        {
            return kisaKenarUzunlugu * uzunKenarUzunlugu;
        }

        public override double getCevre()
        {
            return (kisaKenarUzunlugu + uzunKenarUzunlugu) * 2;
        }

        public override void yazdir()
        {
            Console.WriteLine("Dikdörtgenin kısa kenar uzunluğu:" + this.kisaKenarUzunlugu);
            Console.WriteLine("Dikdörtgenin uzun kenar uzunluğu:" + this.uzunKenarUzunlugu);
            Console.WriteLine("Dikdörtgenin alanı:" + this.getAlan());
            Console.WriteLine("Dikdörtgenin çevresi:" + this.getCevre() + "\n");
        }
    }
}
