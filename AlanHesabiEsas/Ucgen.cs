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
            return ((this.Kenar * this.Kenar) * Math.Sqrt(3)) / 4;
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