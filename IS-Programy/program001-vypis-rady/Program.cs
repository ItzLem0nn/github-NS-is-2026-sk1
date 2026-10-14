string again = "a";

// Řídící cyklus programu
// ToLower() - převede vstup na malá písmena, aby bylo možné zadat "A" nebo "a"
// Jakýkoliv jiný vstup program ukončí
while (again.ToLower() == "a")
{
    


    // Dotaz k uživateli na opakování
    Console.WriteLine();
    Console.Write("Pro opakování programu stisněte klávesu A. Následně potvďte klávesou Enter.");
    again = Console.ReadLine() ?? "";
}