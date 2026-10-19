using System.Transactions;

string again = "a";

// Řídící cyklus programu
// ToLower() - převede vstup na malá písmena, aby bylo možné zadat "A" nebo "a"
// Jakýkoliv jiný vstup program ukončí
while (again.ToLower() == "a")
{
    Console.Clear();

    
    //Hlavička programu
    Console.WriteLine("*******************************");
    Console.WriteLine("**********Výpis řady***********");
    Console.WriteLine("*******************************");
    Console.WriteLine("********Nicol Schánělová*******");
    Console.WriteLine("*******************************");

    //vstup počáteční hodnoty
    Console.Write("Zadejte počáteční hodnotu řady: ");
    int first;
    while(!int.TryParse(Console.ReadLine(), out first))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu:");
    };

        //vstup konečné hodnoty
    Console.Write("Zadejte konečnou hodnotu řady: ");
    int last;
    while(!int.TryParse(Console.ReadLine(), out last))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte konečnou hodnotu řady znovu:");
    };

     //vstup diferenční hodnoty
    Console.Write("Zadejte diferenci řady: ");
    int step;
    while(!int.TryParse(Console.ReadLine(), out step) || step <= 0)
    {
        Console.Write("Nezadali jste celé číslo. Zadejte diferenci řady znovu:");
    };

    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine ("===============================");
    Console.WriteLine($"Zadané hodnoty: počáteční hodnota = {first}, konečná hodnota = {last}, diferenci = {step}");
    Console.WriteLine("===============================");
    Console.WriteLine();

    //výpis řady
    Console.WriteLine("Výpis řady:");
    if (first <= last)
    {
        int current = first;
        while (current <= last)
        {
            Console.WriteLine(current);
            current += step;
        }
    }
    else
    {
        int current = first;
        while (current <= last)
        {
            Console.WriteLine(current);
            current += step;
        }
    }
    
    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisněte klávesu A. Následně potvďte klávesou Enter:");
    again = Console.ReadLine() ?? "";
}