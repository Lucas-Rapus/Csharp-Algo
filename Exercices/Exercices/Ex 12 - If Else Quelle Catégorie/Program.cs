Console.WriteLine($"--- Dans quelle catégorie mon enfant est-il... ? ---");
Console.WriteLine($"Entrez l'age de votre enfant : ");
int age = Convert.ToInt32(Console.ReadLine());
if (age >= 3)
{
    Console.WriteLine($"Votre enfant est dans la catégorie : 'Baby'");
}
else if (age >= 7)
{
    Console.WriteLine($"Votre enfant est dans la catégorie : 'Poussin'");
}
else if (age >= 9)
{
    Console.WriteLine($"Votre enfant est dans la catégorie : 'Pupille'");
}
else if (age >= 11)
{
    Console.WriteLine($"Votre enfant est dans la catégorie : 'Minime'");
}
else if (age >= 13)
{
    Console.WriteLine($"Votre enfant est dans la catégorie : 'Cadet'");
}
else
{
    Console.WriteLine($"Hors catégorie !");
}
     