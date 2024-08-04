using System;
using System.Collections.Generic;

namespace SessizHarf
{
    class Program
    {
        public static string sessizler = "bcçdfghjklmnpqrstvwyz";

        static void Main(string[] args)
        {

            Console.WriteLine(SessizBul("Merhabalar"));
        }

        public static bool SessizBul(string cumle)
        {
            char[] arr = cumle.ToCharArray();
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (sessizler.Contains(arr[i]) && sessizler.Contains(arr[i + 1]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
