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

