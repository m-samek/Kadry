# System Kadrowy – Dziedziczenie i Polimorfizm w C#

## Opis projektu

Projekt przedstawia prosty system zarządzania pracownikami z zastosowaniem dziedziczenia i polimorfizmu w języku C#. System umożliwia przechowywanie i obliczanie informacji o różnych typach pracowników, takich jak:

- Pracownik biurowy
- Menedżer
- Pracownik zdalny

Każdy z typów pracowników dziedziczy po klasie abstrakcyjnej `Pracownik`, która definiuje wspólne właściwości i metody, takie jak:

- `Imie`, `Nazwisko`, `Stanowisko`, `Wynagrodzenie`
- `ObliczRoczneWynagrodzenie()`
- `ObliczDzienneWynagrodzenie()`
- `ObliczMiesieczneWynagrodzenie()`

## Struktura projektu

```
Kadry/
├── Pracownik.cs
├── Kadry.csproj
└── Tests/
    └── PracownikTests.cs
```

## Technologie

- C# 10 / .NET 6
- Visual Studio 2022
- xUnit (testy jednostkowe)

## Jak uruchomić

1. Sklonuj repozytorium:
```bash
git clone https://github.com/twoj-login/Kadry.git
cd Kadry
```

2. Uruchom projekt w Visual Studio **lub** zbuduj ręcznie:
```bash
dotnet build
```

3. Uruchom testy:
```bash
dotnet test
```

## Przykład działania

```csharp
Pracownik pracownik = new PracownikBiurowy()
{
    Imie = "Anna",
    Nazwisko = "Kowalska",
    Stanowisko = "Asystentka",
    Wynagrodzenie = 5000,
    IloscGodzinPracy = 170
};

pracownik.PokazInformacje();
Console.WriteLine(pracownik.ObliczRoczneWynagrodzenie());
```

## Wnioski i znaczenie

Projekt został zrealizowany w ramach laboratorium z programowania obiektowego. Jego celem było praktyczne zastosowanie następujących zagadnień:

- Dziedziczenie i klasy abstrakcyjne
- Polimorfizm i metody wirtualne
- Implementacja wzorców projektowych w modelowaniu rzeczywistych problemów
- UML jako narzędzie wspierające projektowanie systemów

Projekt ukazuje, jak można tworzyć elastyczne i rozszerzalne aplikacje biznesowe, które łatwo rozbudowywać o nowe typy obiektów.

## Autor

Imię i nazwisko autora projektu lub grupa laboratoryjna.