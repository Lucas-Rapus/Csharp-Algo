Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"--- Quelle boisson souhaitez vous : ---\n");
Console.ForegroundColor = ConsoleColor.Gray;
Console.WriteLine($"Liste des boissons disponibles : ");
Console.WriteLine($"\t1) Eau Plate\n\t2) Eau Gazeuse\n\t3) Coca-cola\n\t4) Fanta\n\t5) Sprite\n\t6) Orangina\n\t7) 7up");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"\nFaites votre Choix : ");
Console.ForegroundColor = ConsoleColor.Gray;
string choix = Console.ReadLine();

switch (choix)
{
    case "1":
        Console.WriteLine($"Votre Eau Plate est servi ! Bonne dégustation ;) ");
        break;
    case "2":
        Console.WriteLine($"Votre Eau Gazeuse est servi ! Bonne dégustation ;) ");
        break;
    case "3":
        Console.WriteLine($"Votre Coca-cola est servi ! Bonne dégustation ;) ");
        break;
    case "4":
        Console.WriteLine($"Votre Fanta est servi ! Bonne dégustation ;) ");
        break;
    case "5":
        Console.WriteLine($"Votre Sprite est servi ! Bonne dégustation ;) ");
        break;
    case "6":
        Console.WriteLine($"Votre Orangina est servi ! Bonne dégustation ;) ");
        break;
    case "7":
        Console.WriteLine($"Votre 7up est servi ! Bonne dégustation ;) ");
        break;
}