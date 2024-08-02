
namespace AlanHesabiEsas
{
    class Kare : Sekil
    {
        public double Kenar { get; set; }
        public Kare(double kenar)
        {
            this.Kenar = kenar;
        }
        public override double AlanHesapla()
        {
            return Kenar * Kenar;
        }
        public override double HacimHesapla()
        {
            return Kenar * Kenar * Kenar;
        }
        public override double CevreHesapla()
        {
            return 4 * Kenar;
        }
    }
}