Console.WriteLine($"--- Dans quelle catégorie mon enfant est-il... ? ---");
Console.WriteLine($"Entrez l'age de votre enfant : ");
int age = Convert.ToInt32(Console.ReadLine());

switch (age)
{
    case < 3:
        Console.WriteLine("ERREUR !!!! AGE INVALIDE !\nl'age minimum requis est de : 3ans ");
        break;
    case < 6:
        Console.WriteLine($"Votre enfant est dans la catégorie : 'Baby'");
        break;
    case < 8:
        Console.WriteLine($"Votre enfant est dans la catégorie : 'Poussin'");
        break;
    case < 10:
        Console.WriteLine($"Votre enfant est dans la catégorie : 'Pupille'");
        break;
    case < 12:
        Console.WriteLine($"Votre enfant est dans la catégorie : 'Minime'");
        break;
    default:
        Console.WriteLine($"Votre enfant est dans la catégorie : 'Cadet'");
        break;
    }