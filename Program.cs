using System;

namespace hejswiecie
{
    class Program
    {
        static int wynik;
        static int PisanieJakisRzeczy()
        {
            Console.WriteLine("Podaj mi jakas cyfre");
            int cyferka = Convert.ToInt16(Console.ReadLine());
            if(cyferka == 5)
            {
                wynik = 1;
                return wynik;
            }
            else if((cyferka == 4) | (cyferka == 6))
            {
                wynik = 2;
                return wynik;
            }
            else
            {
                wynik = 3;
                return wynik;
            }
        }   
        static void Main(string[] args)
        {
            Console.WriteLine("Hej swiecie!");
            Console.WriteLine("Czas teraz to " + DateTime.Now);
            PisanieJakisRzeczy();
            if (wynik == 1)
            {
                Console.WriteLine("Brawo! Zgadles!");
                return;
            }
            else if(wynik == 2) 
            {
                Console.WriteLine("Byles blisko!");
                return;
            }
            else if(wynik == 3)
            {
                Console.WriteLine("Niestety nie udalo ci sie, sprobowac ponownie?");
                string powtorz = Console.ReadLine();
                powtorka:
                if(powtorz == "Tak")
                {
                    PisanieJakisRzeczy();
                }
                else if(powtorz == "Nie")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Niepoprawna odpowiedz");
                    powtorz = Console.ReadLine();
                    goto powtorka;
                }
            }
            else
            {
                Console.WriteLine("Gosciu jak ty to zrobiles");
                return;
            }
        }
    }
}
