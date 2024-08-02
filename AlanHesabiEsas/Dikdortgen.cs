namespace AlanHesabiEsas
{
    class Dikdortgen : Sekil
    {
        public double Kisa { get; set; }
        public double Uzun { get; set; }
        public double Derinlik { get; set; }
        public Dikdortgen(double Uzun, double Kisa, double Derinlik)
        {
            this.Uzun = Uzun;
            this.Kisa = Kisa;
            this.Derinlik = Derinlik;
        }

        public override double AlanHesapla()
        {
            return this.Uzun * this.Kisa;
        }
        public override double CevreHesapla()
        {
            return 2 * (this.Kisa + this.Uzun);
        }
        public override double HacimHesapla()
        {
            return this.Derinlik * this.Uzun * this.Kisa;
        }
    }
}