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
for(int i = 1; i <= height; i++)
    {
        //obarvení každého řádku dvěmi barvami - liché řádky červené, sudé řádky modré
        if (i % 2 == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }

        //vnitřní cyklus, který se postará, aby se v každém řádku vykreslil počet znaků podle zadané šířky
        for(int j = 1; j <= width; j++)
        {
        Console.Write("* ");
        System.Threading.Thread.Sleep(System.TimeSpan.FromMilliseconds(100)); // Efekt animace vykreslování
        }
        Console.WriteLine();
    }
    Console.ResetColor(); // Obnovení výchozí barvy textu


    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisněte klávesu A. Následně potvďte klávesou Enter:");
    again = Console.ReadLine() ?? "";
}