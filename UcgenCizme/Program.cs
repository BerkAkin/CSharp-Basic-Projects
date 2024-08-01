using System;

namespace UcgenCizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Üçgenin yüksekliğini girin:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                Console.Write(new string(' ', height - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }
    }
}
