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
                Console.WriteLine("Alan: " + sekil.CevreHesapla());
            }
            else
            {
                Console.WriteLine("Alan: " + sekil.HacimHesapla());
            }
        }
    }
}