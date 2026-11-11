using System.Transactions;

string again = "a";

// Řídící cyklus programu
// ToLower() - převede vstup na malá písmena, aby bylo možné zadat "A" nebo "a"
// Jakýkoliv jiný vstup program ukončí
while (again.ToLower() == "a")
{
    Console.Clear();

    
    //Hlavička programu
    Console.WriteLine("********************************");
    Console.WriteLine("******Vykreslování obrazců******");
    Console.WriteLine("********************************");
    Console.WriteLine("********Nicol Schánělová********");
    Console.WriteLine("********************************");

    //vstup výšky
    Console.Write("Zadejte výšku: ");
    int height;
    while(!int.TryParse(Console.ReadLine(), out height) || height <= 0)
    {   
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte výšku znovu:");
        Console.ResetColor();
    };

    //vstup šířky
    Console.Write("Zadejte šířku: ");
    int width;
    while(!int.TryParse(Console.ReadLine(), out width) || width <= 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("Nezadali jste celé kladné číslo. Zadejte šířku znovu:");
        Console.ResetColor();
    };

    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine ("===============================");
    Console.WriteLine($"Zadané hodnoty: výška = {height}, šířka = {width}");
    Console.WriteLine("===============================");
    Console.WriteLine();

//Jádro vykreslovacího algoritmu
//Vnější cyklus, který bude hlídat počet řádků (výšku)
for(int i = 0; i <= height; i++)
    {
        Console.WriteLine("* ");
    }


    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisněte klávesu A. Následně potvďte klávesou Enter:");
    again = Console.ReadLine() ?? "";
}