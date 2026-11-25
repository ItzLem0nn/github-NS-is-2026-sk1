using System.Transactions;

string again = "a";

// Řídící cyklus programu
while (again.ToLower() == "a")
{
    Console.Clear();

    // Hlavička programu
    Console.WriteLine("***********************************");
    Console.WriteLine("*********Minimum a maximum*********");
    Console.WriteLine("***********************************");
    Console.WriteLine("**********Nicol Schánělová*********");
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


    // Generování náhodných čísel a jejich uložení do pole
    Console.WriteLine("Vygenerovaná čísla:");
    for (int i = 0; i < myRandNumbs.Length; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(LowerBound, UpperBound + 1);
        Console.Write($"{myRandNumbs[i]}; ");
    }

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0; 

    for(int i = 1; i < n; i++)
    {
        if(myRandNumbs[i] > max)
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if(myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }
    }

    Console.WriteLine();
    Console.WriteLine("===============================");
    Console.WriteLine($"Maximální hodnota: {max}, pozice prvního maxima: {posMax}");
    Console.WriteLine($"Minimální hodnota: {min}, pozice prvního minima: {posMin}");
    Console.WriteLine("===============================");

    //vykreslování přesýpacích hodin
    if (max >= 3)
    {
        for(int i = 0; i < max; i++)
        {   
            int spaces = 0; //proměnná pro počet úvodních mezer, které se budou vykreslovat před hvězdičkami
            int stars = 0; //proměnná pro počet hvězdiček, které se budou vykreslovat v každém řádku
            if (i < max/2)
            {
                //horní část přesýpacích hodin
                spaces = i;
                stars = max - (2 * i);
            }
            else
            {
                //dolní část přesýpacích hodin
                spaces = max - i - 1;
                stars = max - (2 * spaces);
            }

            //samotné vykreslování aktuálního řádku přesýpacích hodin
            for(int sp = 0; sp < spaces; sp++)
            {
                Console.Write(" ");
            }
            
            //následné vykreslování hvězdiček v aktuálním řádku přesýpacích hodin
            for(int st = 0; st < stars; st++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); //přechod na nový řádek po vykreslení aktuálního řádku přesýpacích hodin
        }
    }
    else
    {
        Console.WriteLine("Maximální hodnota je menší než 3, přesýpací hodiny nelze vykreslit.");
    }

    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.WriteLine();
    Console.Write("Pro opakování programu stisknete klávesu A. Potvrďte klávesou Enter: ");
    again = Console.ReadLine() ?? "";
}