using System;
using Xunit;
using Kadry;

namespace Kadry.Tests
{
    public class PracownikTests
    {
        [Fact]
        public void PracownikBiurowy_ObliczRoczneWynagrodzenie_ZNadgodzinami()
        {
            // Arrange
            var pracownik = new PracownikBiurowy
            {
                Imie = "Jan",
                Nazwisko = "Kowalski",
                Stanowisko = "Asystent",
                Wynagrodzenie = 4000m,
                IloscGodzinPracy = 180
            };

            // Act
            var wynik = pracownik.ObliczRoczneWynagrodzenie();

            // 4000 * 12 + 20 * (4000 / 160)
            var expected = 48000 + 500;

            // Assert
            Assert.Equal(expected, wynik);
        }

        [Fact]
        public void Menedzer_ObliczRoczneWynagrodzenie_ZBonusem()
        {
            var menedzer = new Menedzer
            {
                Imie = "Anna",
                Nazwisko = "Nowak",
                Stanowisko = "Kierownik",
                Wynagrodzenie = 10000m,
                BonusRoczny = 12000m
            };

            var wynik = menedzer.ObliczRoczneWynagrodzenie();

            var expected = 10000 * 12 + 12000;

            Assert.Equal(expected, wynik);
        }

        [Fact]
        public void PracownikZdalny_ObliczRoczneWynagrodzenie_ZDniamiZdalnymi()
        {
            var zdalny = new PracownikZdalny
            {
                Imie = "Tomasz",
                Nazwisko = "Zielinski",
                Stanowisko = "Programista",
                Wynagrodzenie = 8000m,
                IloscDniZdalnych = 30,
                StawkaZaDzienZdalny = 100m
            };

            var wynik = zdalny.ObliczRoczneWynagrodzenie();

            var expected = 8000 * 12 + 3000;

            Assert.Equal(expected, wynik);
        }

        [Fact]
        public void ObliczDzienneWynagrodzenie_PoprawnaWartosc()
        {
            var pracownik = new PracownikBiurowy
            {
                Imie = "Ala",
                Nazwisko = "Makota",
                Stanowisko = "Recepcjonistka",
                Wynagrodzenie = 4200m
            };

            var wynik = pracownik.ObliczDzienneWynagrodzenie();
            var expected = 4200 / 21;

            Assert.Equal(expected, wynik);
        }
    }
}
