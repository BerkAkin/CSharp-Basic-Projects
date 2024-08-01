using System;
using System.Security.Cryptography.X509Certificates;

namespace DaireCizme
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dairenin çapını girin (genişlik ve yükseklik olarak):");
            int diameter = int.Parse(Console.ReadLine());

            DrawCircle(diameter);
        }

        static void DrawCircle(int diameter)
        {
            int radius = diameter / 2;
            for (int y = 0; y < diameter; y++)
            {
                for (int x = 0; x < diameter; x++)
                {
                    // Dairenin içindeki noktaları hesapla
                    double distance = Math.Sqrt(Math.Pow(x - radius, 2) + Math.Pow(y - radius, 2));

                    if (distance > radius - 0.5 && distance < radius + 0.5)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }
    }

}
