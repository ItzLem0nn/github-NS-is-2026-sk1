using System.Transactions;

string again = "a";

// Řídící cyklus programu
while (again.ToLower() == "a")
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("***********************************");
    Console.WriteLine("**Generátor pseudonáhodných čísel**");
    Console.WriteLine("***********************************");
    Console.WriteLine("********Nicol Schánělová***********");
    Console.WriteLine("***********************************");

    // Počet generovaných čísel větší než 0
    Console.Write("Zadejte počet generovaných čísel (přirozené číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte počet čísel znovu: ");
    }

    // Načtení dolní meze
    Console.Write("Zadejte dolní mez (celé číslo): ");
    int LowerBound;
    while (!int.TryParse(Console.ReadLine(), out LowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

    // Načtení horní meze
    Console.Write("Zadejte horní mez (celé číslo, větší nebo rovno dolní meze): ");
    int UpperBound;
    while (!int.TryParse(Console.ReadLine(), out UpperBound) || UpperBound < LowerBound)
    {
        Console.Write("Horní mez musí být celé číslo a nesmí být menší než dolní mez. Zadejte znovu: ");
    }

    //rekapitulace zadaných hodnot
    Console.WriteLine();
    Console.WriteLine ("===============================");
    Console.WriteLine($"Počet generovaných čísel: {n}; Dolní mez: {LowerBound}; Horní mez: {UpperBound}");
    Console.WriteLine("===============================");
    Console.WriteLine();


    // Deklarace a alokace pole pro generovaná čísla
    int[] myRandNumbs = new int[n];

    // Inicializace generátoru náhočných čísel
    Random myRandNumb = new Random();
    //Random myRandNumb = new Random(50); - při opakovaném spuštění programu se vygenerují stejná čísla, protože je generátor inicializován stejným semínkem (seedem)

    // Deklarace proměnných pro počítání kladných, záporných, sudých, lichých a nulových čísel
    int positiveCount = 0;
    int negativeCount = 0;
    int evenCount = 0;
    int oddCount = 0;
    int zeroCount = 0;

    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná pseudonáhodná čísla:");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(LowerBound, UpperBound + 1);
        Console.Write($"{myRandNumbs[i]}; ");

        /*if (myRandNumbs[i] > 0)
        {
            positiveCount++;
        }
        if (myRandNumbs[i] < 0)
        {
            negativeCount++;
        }
        if (myRandNumbs[i] % 2 == 0)
        {
            evenCount++;
        }
        if (myRandNumbs[i] % 2 != 0)
        {
            oddCount++;
        }
        if (myRandNumbs[i] == 0)
        {
            zeroCount++;
        }*/

        if(myRandNumbs[i]<0)
        {
            negativeCount++;
        }
        else if(myRandNumbs[i]>0)
        {
            positiveCount++;
        }
        else
        {
            zeroCount++;
        }

        if(myRandNumbs[i]%2==0)
        {
            evenCount++;
        }
        else
        {
            oddCount++;
        }


    }

    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine($"Počet kladných čísel: {positiveCount}");
    Console.WriteLine($"Počet záporných čísel: {negativeCount}");
    Console.WriteLine($"Počet nul: {zeroCount}");
    Console.WriteLine($"Počet sudých čísel: {evenCount}");
    Console.WriteLine($"Počet lichých čísel: {oddCount}");
    Console.WriteLine("===============================");


    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Pro opakování programu stisknete klávesu A. Potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}