using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kadry;

class Program
{
    static void Main(string[] args)
    {
        Pracownik biurowy = new PracownikBiurowy
        {
            Imie = "Jan",
            Nazwisko = "Kowalski",
            Stanowisko = "Księgowy",
            Wynagrodzenie = 4000m,
            IloscGodzinPracy = 170
        };

        Pracownik menedzer = new Menedzer
        {
            Imie = "Anna",
            Nazwisko = "Nowak",
            Stanowisko = "Menedżer Projektu",
            Wynagrodzenie = 8000m,
            BonusRoczny = 10000m
        };

        Pracownik zdalny = new PracownikZdalny
        {
            Imie = "Piotr",
            Nazwisko = "Wiśniewski",
            Stanowisko = "Programista",
            Wynagrodzenie = 6000m,
            IloscDniZdalnych = 10,
            StawkaZaDzienZdalny = 200m
        };

        biurowy.PokazInformacje();
        Console.WriteLine($"Roczne wynagrodzenie: {biurowy.ObliczRoczneWynagrodzenie()}");

        menedzer.PokazInformacje();
        Console.WriteLine($"Roczne wynagrodzenie: {menedzer.ObliczRoczneWynagrodzenie()}");

        zdalny.PokazInformacje();
        Console.WriteLine($"Roczne wynagrodzenie: {zdalny.ObliczRoczneWynagrodzenie()}, miesięczne: {zdalny.ObliczMiesieczneWynagrodzenie()}, dzienne: {zdalny.ObliczDzienneWynagrodzenie()}");
    }
}
