using System;

namespace zad_dom_2021_08_30
{
    class Program
    {
        //1 przerub ten program tak aby po uruchomieniu on pytał czy chcesz policzyć nww czy nwd
        //2 wrzuc te zmainy na githuba
        // git add -A (dodaje wszystkie zmiany na dysku do zkomitowania)
        // git commit -m " tu jest opis"  <--- towrzy niejako paczke zmian 
        //git push <--- wysłą zmiany na serwa =)
        // cd 
        //git status    

        static void Main(string[] args)
        {
            Console.WriteLine("Witam w kalklatorze NWD i NWW");
            Console.WriteLine("(jeżeli chcesz obliczyć NWD napisz NWD a jeżeli NWW to NWW) (NAPISZ MAŁYMI LITERAMI)");
            string Sprawdzanie = Console.ReadLine();
            if (Sprawdzanie == "nwd")
            {
                Program.Main3();
            }
            if (Sprawdzanie == "nww")
            {
                Program.Main2();
            }
        }
        public static void Main3()
        {
            int liczba1 = Program.PobierzLiczbe(1);
            int liczba2 = Program.PobierzLiczbe(2);
            int nwd = Program.NWD(liczba1, liczba2);
            Console.WriteLine(nwd + " to jest właśnie twojia liczba");
        }
        private static int PobierzLiczbe(int numerLiczby)
        {
            Console.WriteLine("podaj liczbe " + numerLiczby);
            string liczbaString1 = Console.ReadLine();
            int liczba1 = int.Parse(liczbaString1);
            return liczba1;
        }
        private static int NajmniejszaLiczba(int liczba1, int liczba2)
        {
            int najmniejszaLiczba;
            if (liczba1 >= liczba2)
            {
                najmniejszaLiczba = liczba2;
            }
            else
            {
                najmniejszaLiczba = liczba1;
            }
            return najmniejszaLiczba;
        }
        private static int NWD(int liczba1, int liczba2)
        {
            int najmniejszaLiczba = Program.NajmniejszaLiczba(liczba1, liczba2);
            for (int i = najmniejszaLiczba; i > 0; i--)
            {
                if (liczba1 % i == 0 && liczba2 % i == 0)
                {
                    return i;
                }

            }
            return 0;
        }
        public static void Main2()
        {
            int liczba1 = Program.PobierzLiczbe2(1);
            int liczba2 = Program.PobierzLiczbe2(2);
            int nww = Program.NWw2(liczba1, liczba2);
            Console.WriteLine(nww + " to jest właśnie twojia liczba");
        }
        private static int PobierzLiczbe2(int numerLiczby)
        {
            Console.WriteLine("podaj liczbe " + numerLiczby);
            string liczbaString1 = Console.ReadLine();
            int liczba1 = int.Parse(liczbaString1);
            return liczba1;
        }
        private static int NajwiekszaLiczba2(int liczba1, int liczba2)
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
        private static int NWw2(int liczba1, int liczba2)
        {
            int najwiekszaLiczba = Program.NajwiekszaLiczba2(liczba1, liczba2);
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
