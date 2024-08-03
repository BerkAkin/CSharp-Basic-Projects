using System;
using System.Collections;

namespace MutlakKare
{
    class Program
    {
        const int Number = 67;
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList() { 13, 78, 45, 10, 45 };
            ArrayList mutlakListe = MutlakKare(arrayList);
            foreach (int i in mutlakListe)
            {
                Console.Write(i + " ");
            }
        }
        public static ArrayList MutlakKare(ArrayList arr)
        {
            ArrayList donecekDizi = new ArrayList();
            int Kucukler = 0;
            int Buyukler = 0;

            foreach (int num in arr)
            {
                if (num < 67)
                {
                    Kucukler += (67 - num);
                }
                else
                {
                    int buyuk = 67 - num;
                    Buyukler += (int)Math.Pow(buyuk, 2);
                }
            }
            donecekDizi.Add(Kucukler);
            donecekDizi.Add(Buyukler);
            return donecekDizi;
        }
    }
}
