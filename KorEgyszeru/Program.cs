using System;

namespace KorEgyszeru
{
    class Program
    {
        static void Main(string[] args)
        {
            int r = 0;
            //string tmp = string.Empty;
            double ter;
            double ker;
            Console.Write("Kerjuk add meg a kor sugarat: ");

            //tmp = Console.ReadLine();
            // r = Convert.ToInt32(tmp);
            r = Convert.ToInt32(Console.ReadLine());

            ker = 2 * r * Math.PI;
            ter = Math.Pow(r, 2) * Math.PI; // r * r

            // Console.WriteLine("A kerulet: {0:N2}",ker);
            // Console.WriteLine("A terulet: {0:N2}",ter);
            // két tizedesre kerekítve lehet kiiratni
            Console.WriteLine("A kerulet: {0}", ker);
            Console.WriteLine("A terulet: {0}", ter);

            Console.ReadKey();
        }
    }
}
