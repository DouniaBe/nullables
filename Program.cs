// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main()
    {
        // Vraag om de naam van de werknemer
        Console.Write("Voer de naam van de werknemer in: ");
        string naam = Console.ReadLine();

        // Vraag om de duur van de werkzaamheden in elke afdeling
        Console.Write("Hoeveel jaar heeft de werknemer in de Verkoopafdeling gewerkt? ");
        int verkoopJaren = int.Parse(Console.ReadLine());

        Console.Write("Hoeveel jaar heeft de werknemer in de Ondersteuningsafdeling gewerkt? ");
        int ondersteuningJaren = int.Parse(Console.ReadLine());

        Console.Write("Hoeveel jaar heeft de werknemer in de Administratieafdeling gewerkt? ");
        int administratieJaren = int.Parse(Console.ReadLine());

        // Bereken het totale aantal jaren in minstens 2 van de 3 afdelingen
        int totaalJaren = verkoopJaren + ondersteuningJaren + administratieJaren;
        int minstensTweeAfdelingen = (verkoopJaren > 0 ? 1 : 0) + (ondersteuningJaren > 0 ? 1 : 0) + (administratieJaren > 0 ? 1 : 0);

        // Bereken het bonuspercentage
        double bonusPercentage = 0;
        if (minstensTweeAfdelingen >= 2)
        {
            bonusPercentage = Math.Min(totaalJaren, 20) * 0.02; // Maximaal 20 jaar telt mee voor de bonus
        }

        // Toon de resultaten
        Console.WriteLine($"Naam van de werknemer: {naam}");
        Console.WriteLine($"Duur van de werkzaamheden voor de Verkoopafdeling: {verkoopJaren} jaar");
        Console.WriteLine($"Duur van de werkzaamheden voor de Ondersteuningsafdeling: {ondersteuningJaren} jaar");
        Console.WriteLine($"Duur van de werkzaamheden voor de Administratieafdeling: {administratieJaren} jaar");
        Console.WriteLine($"Bonuspercentage: {bonusPercentage}%");
    }
}

