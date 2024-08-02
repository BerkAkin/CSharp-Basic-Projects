using System;

namespace AlanHesabiEsas
{
    class Ucgen : Sekil
    {
        public double Kenar { get; set; }
        public double Yukseklik { get; set; }
        public Ucgen(double kenar, double Yukseklik)
        {
            this.Kenar = kenar;
            this.Yukseklik = Yukseklik;
        }
        public override double AlanHesapla()
        {
            double alan = (Math.Pow(this.Kenar, 2) * Math.Sqrt(3)) / 4;
            return alan;
        }
        public override double CevreHesapla()
        {
            return 3 * this.Kenar;
        }

        public override double HacimHesapla()
        {
            return ((Kenar * Kenar) * Math.Sqrt(3)) * this.Yukseklik / 12;
        }
    }
}