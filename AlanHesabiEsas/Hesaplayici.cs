using System;

namespace AlanHesabiEsas
{
    public static class Hesaplayici
    {
        public static void Hesapla(ISekil sekil, string metot)
        {
            if (metot.Equals("alan"))
            {
                Console.WriteLine("Alan: " + sekil.AlanHesapla());
            }
            else if (metot.Equals("cevre"))
            {
                Console.WriteLine("Cevre: " + sekil.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Hacim: " + sekil.HacimHesapla());
            }
        }
    }
}