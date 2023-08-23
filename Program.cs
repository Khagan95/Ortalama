using System;

namespace FibonacciOrtalamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fibonacci serisi derinliği: ");
            int derinlik = Convert.ToInt32(Console.ReadLine());

            Fibonacci fibonacci = new Fibonacci();
            double ortalama = fibonacci.HesaplaOrtalama(derinlik);

            Console.WriteLine($"Fibonacci serisi {derinlik} derinliğindeki rakamların ortalaması: {ortalama}");
        }
    }

    class Fibonacci
    {
        public double HesaplaOrtalama(int derinlik)
        {
            int[] fibSerisi = FibonacciSerisi(derinlik);
            double toplam = 0;

            foreach (int rakam in fibSerisi)
            {
                toplam += rakam;
            }

            double ortalama = toplam / derinlik;
            return ortalama;
        }

        private int[] FibonacciSerisi(int derinlik)
        {
            int[] serisi = new int[derinlik];

            for (int i = 0; i < derinlik; i++)
            {
                if (i == 0 || i == 1)
                {
                    serisi[i] = i;
                }
                else
                {
                    serisi[i] = serisi[i - 1] + serisi[i - 2];
                }
            }

            return serisi;
        }
    }
}