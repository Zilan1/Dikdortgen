using System;
namespace ConsoleApp7
{
    class dikdortgen
    {
        private int a, b;
        public dikdortgen(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public int AlanHesapla()
        {
            return a * b;
        }
        public int CevreHesapla()
        {
            return 2*(a + b);
        }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            dikdortgen d = new dikdortgen(3, 4);
            Console.WriteLine("Dikdortgen Alani: {0}",d.AlanHesapla());
            Console.WriteLine("Dikdirtgen Cevresi: {0}", d.CevreHesapla());
        }
    }

}