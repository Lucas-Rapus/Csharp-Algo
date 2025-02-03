Console.WriteLine($"--- Le nom est-il divisible par ? ---");
Console.WriteLine($"Entrez un chiffre / nombre entier : ");
int nbr1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Entrez un second chiffre / nombre :");
int nbr2 = Convert.ToInt32(Console.ReadLine());

if (nbr2 == 0)
{
    Console.WriteLine("Erreur : la division par zéro n'est pas possible.");
}
else
{
    if (nbr1 % nbr2 == 0)
    {
        Console.WriteLine($"Le nombre {nbr1} est divisible par {nbr2}.");
    }
    else
    {
        Console.WriteLine($"Le nombre {nbr1} n'est pas divisible par {nbr2}.");
    }
}
