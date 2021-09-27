using System;

namespace zad_dom_2021_08_30
{
    class Program
    {
        public static void Main(string[] args)
        {
            int liczba1 = Program.PobierzLiczbe(1);
            int liczba2 = Program.PobierzLiczbe(2);
            int nww = Program.NWw(liczba1, liczba2);
            Console.WriteLine(nww + " to jest właśnie twojia liczba");
        }
        private static int PobierzLiczbe(int numerLiczby)
        {
            Console.WriteLine("podaj liczbe " + numerLiczby);
            string liczbaString1 = Console.ReadLine();
            int liczba1 = int.Parse(liczbaString1);
            return liczba1;
        }
        private static int NajwiekszaLiczba(int liczba1, int liczba2)
        {
            int najwiekszaLiczba;
            if (liczba1 >= liczba2)
            {
                najwiekszaLiczba = liczba1;
            }
            else
            {
                najwiekszaLiczba = liczba2;
            }
            return najwiekszaLiczba;
        }
        private static int NWw(int liczba1, int liczba2)
        {
            int najwiekszaLiczba = Program.NajwiekszaLiczba(liczba1, liczba2);
            for (int i = najwiekszaLiczba; i > 0; i++)
            {
                if (i % liczba1 == 0 && i % liczba2 == 0)
                {
                    return i;
                }

            }
            return 0;
        }
    }
}
