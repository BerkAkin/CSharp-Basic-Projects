using System;

namespace KarakterDegisimi
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle = "What's your blood made of";
            KarakterDegis(cumle);
        }
        public static void KarakterDegis(string cumle)
        {
            if (string.IsNullOrEmpty(cumle) || cumle.Length == 1)
            {
                Console.WriteLine(cumle);
            }
            char[] chars = cumle.ToCharArray();
            (chars[0], chars[chars.Length - 1]) = (chars[chars.Length - 1], chars[0]);
            Console.WriteLine(new string(chars));
        }
    }
}
