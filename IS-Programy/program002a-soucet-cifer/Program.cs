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
    Console.WriteLine("*********Součet cifer**********");
    Console.WriteLine("*******************************");
    Console.WriteLine("********Nicol Schánělová*******");
    Console.WriteLine("*******************************");
}

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

//Konkrétní algoritmus - součet cifer zadaného čísla

//Příprava pomovných proměnných pro výpočet součtu cifer
int numberBackup = number; //záloha zadaného čísla
int sum = 0; //neutrální hodnota pro součet cifer (pro násobení by to byla 1)
int digit; //pomocná proměnná pro uložení poslední cifry zadaného čísla

//ošetření záporného čísla - převod na kladné číslo
if (number < 0)
{
    number = -number; //převedení záporného čísla na kladné
}