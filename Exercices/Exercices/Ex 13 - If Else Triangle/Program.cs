using System.ComponentModel.DataAnnotations;

Console.WriteLine($"--- Quelle est la nature du triangle ABC ? ---");
Console.WriteLine($"Entrez la longueur du segment AB :");
double AB = Double.Parse(Console.ReadLine());
Console.WriteLine($"Entrez la longueur du segment BC :");
double BC = Double.Parse(Console.ReadLine());
Console.WriteLine($"Entrez la longueur du segment CA :");
double CA = Double.Parse(Console.ReadLine());

if (AB == BC && BC == CA && CA == AB)
{
Console.WriteLine($"Ce triangle est équilatéral");
}
else if (AB == CA )
    {
    Console.WriteLine($"Le Triangle est isocèle en A mais n'est pas équilatéral");

    }
else if (BC == AB)
{
    Console.WriteLine($"Le Triangle est isocèle en B mais n'est pas équilatéral ");
}
else if (CA == BC)
{
    Console.WriteLine($"Le Triangle est isocèle en C mais n'est pas équilatéral ");
}
else
{
    Console.WriteLine($"Le Triangle n'est isocèle ni en A, ni en B et ni en C ");
}