using System;
using System.Collections.Generic;
using System.Text;

namespace Odev2
{
    abstract class Sekil
    {
        public int kenarSayisi = 0;
        public abstract double getCevre();
        public abstract double getAlan();
        public abstract void yazdir();
    }
}
