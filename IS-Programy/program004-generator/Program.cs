using System.Transactions;

string again = "a";

// Vytvoření generátoru náhodných čísel
Random randomNumber = new Random();

// Řídící cyklus programu
while (again.ToLower() == "a")
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("*******************************");
    Console.WriteLine("***Generátor náhodných čísel***");
    Console.WriteLine("*******************************");
    Console.WriteLine("********Nicol Schánělová*******");
    Console.WriteLine("*******************************");

    // Vstup počtu čísel
    Console.Write("Zadejte počet čísel: ");
    int pocet;
    while (!int.TryParse(Console.ReadLine(), out pocet) || pocet <= 0)
    {
        Console.Write("Zadejte kladný počet čísel znovu: ");
    }

    // Vstup dolní meze
    Console.Write("Zadejte dolní mez: ");
    int dolni;
    while (!int.TryParse(Console.ReadLine(), out dolni))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Vstup horní meze
    Console.Write("Zadejte horní mez: ");
    int horni;
    while (!int.TryParse(Console.ReadLine(), out horni) || horni < dolni)
    {
        Console.Write("Horní mez musí být celé číslo a nesmí být menší než dolní mez. Zadejte znovu: ");
    }

    // Vytvoření pole
    int[] cisla = new int[pocet];

    // Počítadla
    int kladna = 0;
    int zaporna = 0;
    int nulova = 0;
    int suda = 0;
    int licha = 0;

    // Generování čísel
    for (int i = 0; i < pocet; i++)
    {
        cisla[i] = randomNumber.Next(dolni, horni + 1);
    }

    // Výpis vygenerovaných čísel
    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine("Vygenerovaná čísla:");

    for (int i = 0; i < pocet; i++)
    {
        Console.Write(cisla[i] + " ");
    }

    Console.WriteLine();
    Console.WriteLine("===============================");

    // Zjištění kladných, záporných a nulových čísel
    for (int i = 0; i < pocet; i++)
    {
        if (cisla[i] > 0)
        {
            kladna++;
        }
        else if (cisla[i] < 0)
        {
            zaporna++;
        }
        else
        {
            nulova++;
        }
    }

    // Zjištění sudých a lichých čísel
    for (int i = 0; i < pocet; i++)
    {
        if (cisla[i] % 2 == 0)
        {
            suda++;
        }
        else
        {
            licha++;
        }
    }

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("Výsledky:");
    Console.WriteLine("================================");
    Console.WriteLine("Kladná čísla: " + kladna);
    Console.WriteLine("Záporná čísla: " + zaporna);
    Console.WriteLine("Nulová čísla: " + nulova);
    Console.WriteLine("Sudá čísla: " + suda);
    Console.WriteLine("Lichá čísla: " + licha);
    Console.WriteLine("================================");

    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisknete klávesu A. Potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}