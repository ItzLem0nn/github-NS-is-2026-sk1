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
    Console.WriteLine("********Název programu*********");
    Console.WriteLine("*******************************");
    Console.WriteLine("********Nicol Schánělová*******");
    Console.WriteLine("*******************************");

    //vstup čísla 1
    Console.Write("Zadejte číslo: ");
    int aaa;
    while(!int.TryParse(Console.ReadLine(), out aaa))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu:");
    };

        //vstup čísla 2
    Console.Write("Zadejte druhé čislo: ");
    int bbb;
    while(!int.TryParse(Console.ReadLine(), out bbb))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte druhé číslo znovu:");
    };

    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine ("===============================");
    Console.WriteLine($"Zadané hodnoty: čislo 1 = {aaa}, čislo 2 = {bbb}");
    Console.WriteLine("===============================");
    Console.WriteLine();

//zde budeme pokračovat konrétním algoritmem 

    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisněte klávesu A. Následně potvďte klávesou Enter:");
    again = Console.ReadLine() ?? "";
}