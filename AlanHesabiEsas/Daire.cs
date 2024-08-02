using System;

namespace AlanHesabiEsas
{
    class Daire : Sekil
    {
        public double Yaricap { get; set; }
        public Daire(double yaricap)
        {
            this.Yaricap = yaricap;
        }
        public override double AlanHesapla()
        {
            return Math.PI * this.Yaricap * this.Yaricap;
        }

        public override double CevreHesapla()
        {
            return Math.PI * 2 * this.Yaricap;
        }

        public override double HacimHesapla()
        {
            return (4 * Math.PI * this.Yaricap * this.Yaricap * this.Yaricap) / 3;
        }
    }
}