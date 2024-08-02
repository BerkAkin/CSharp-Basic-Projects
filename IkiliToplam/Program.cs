using System;
using System.Collections;

namespace IkiliToplam
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList verilen = new ArrayList() { 5, 63, 7, 4, 73, 3, 3, 3 };
            ArrayList ar = IkiliToplam(verilen);

            foreach (int i in ar)
            {
                Console.Write(i + " ");
            }
        }

        public static ArrayList IkiliToplam(ArrayList arr)
        {
            int sayi1 = 0, sayi2 = 0;
            ArrayList arrayList = new ArrayList();

            for (int j = 0; j <= arr.Count - 1; j += 2)
            {
                if (j + 1 < arr.Count)
                {
                    sayi1 = Convert.ToInt32(arr[j]);
                    sayi2 = Convert.ToInt32(arr[j + 1]);
                    if (sayi1 == sayi2)
                    {
                        arrayList.Add((int)Math.Pow((sayi1 + sayi1), 2));
                    }
                    else
                    {
                        arrayList.Add(sayi1 + sayi2);
                    }
                }
                else
                {
                    int lastElement = Convert.ToInt32(arr[j]);
                    arrayList.Add(lastElement);
                }
            }


            return arrayList;
        }
    }
}
