using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasamakAyir2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            string cevap, sayiUzunluk;
            bool SayiMi;


            do
            {
                do
                {
                    Console.WriteLine("Lütfen bir sayı giriniz");
                    SayiMi = int.TryParse(Console.ReadLine(), out sayi);
                    if (!SayiMi)
                    {
                        Console.WriteLine("Lütfen sayısal bir değer girin!");
                    }

                } while (!SayiMi);
                sayi = Math.Abs(sayi);
                sayiUzunluk = sayi.ToString();
                int[] sayiBasamaklari = new int[sayiUzunluk.Length];
                BasamaklarıAt(sayiUzunluk, sayi, sayiBasamaklari);
                for (int i = sayiBasamaklari.Length - 1, j = 0; i >= 0; i--, j++)
                {
                    Console.WriteLine($"{sayiBasamaklari[i]} x {Math.Pow(10, j)} = {sayiBasamaklari[i] * Math.Pow(10, j)}");
                }

                Console.WriteLine("Çıkış yapmak için exit yazınız, devam etmek için herhangi bir tuşa basabilirsiniz");
                cevap = Console.ReadLine();
            } while (cevap != "exit");



        }
        private static int[] BasamaklarıAt(string uzunluk, int sayi, int[] dizi)
        {
            for (long i = uzunluk.Length - 1; i >= 0; i--)
            {
                dizi[i] = sayi % 10;
                sayi = sayi / 10;
            }
            return dizi;
        }
    }
}
