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
    Console.WriteLine("*******Součet cifer 2.0********");
    Console.WriteLine("*******************************");
    Console.WriteLine("********Nicol Schánělová*******");
    Console.WriteLine("*******************************");


//první vstupní hodnota
Console.Write("Zadejte celé číslo: ");
int number;
while (!int.TryParse(Console.ReadLine(), out number))
{
    Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
}


 //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine ("===============================");
    Console.WriteLine($"Zadané číslo: {number}");
    Console.WriteLine("===============================");
    Console.WriteLine();

//Konkrétní algoritmus - součet cifer zadaného čísla POMOCÍ TEXTOVÉHO ŘETĚZCE

//Příprava pomovných proměnných pro výpočet součtu cifer
int numberBackup = number; //záloha zadaného čísla
int sum = 0; //neutrální hodnota pro součet cifer (pro násobení by to byla 1)
int digit; //pomocná proměnná pro uložení poslední cifry zadaného čísla


//převedení čísla na textový řetězec
string text = number.ToString();

Console.WriteLine();
Console.WriteLine("Průběh rozkladu čísla na číslice: ");

foreach(char znak in text)
{
    //kontrola, zda se jedná o číslici
    if(char.IsDigit(znak))
        {
            //Převod znaku na číselnou hodnotu
            digit = znak - '0'; //převedení znaku na číslici

            //Přičtení číslice k součtu
            sum = sum + digit;

            Console.WriteLine($"Získaná číslice: {digit}");
        }   

}

    // Výpis výsledků
    Console.WriteLine();
    Console.WriteLine("=============================");
    Console.WriteLine($"Součet číslic čísla {numberBackup} je {sum}.");
    Console.WriteLine("=============================");
    Console.WriteLine();

    // Dotaz směrem k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stislněte klávesu a. Následně potvrďte klávesou Enter. ");
    Console.WriteLine("Jakokouli jinou klávesou program ukončíte.");
    Console.WriteLine();
    Console.Write("Chcete program spustit znovu? ");
    again = Console.ReadLine() ?? "";
}