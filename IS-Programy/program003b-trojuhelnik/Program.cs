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
    Console.WriteLine("****Vykreslování obrazců 2.0****");
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

    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine ("===============================");
    Console.WriteLine($"Zadané hodnoty: výška = {height}");
    Console.WriteLine("===============================");
    Console.WriteLine();

//Jádro vykreslovacího algoritmu
//Vnější cyklus, který bude hlídat počet řádků (výšku)
for(int i = 1; i <= height; i++)
    {
        //vnitřní cyklus, který se postará, aby se v každém řádku vykreslil obdélník s počtem znaků podle zadané výšky
        for(int j = 1; j <= i; j++)
        {
        Console.Write("* ");
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
        }
        Console.WriteLine(); // Přechod na nový řádek po dokončení aktuálního řádku
    }
    Console.ResetColor(); // Obnovení výchozí barvy textu


    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisněte klávesu A. Následně potvďte klávesou Enter:");
    again = Console.ReadLine() ?? "";
}