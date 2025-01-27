Console.WriteLine($"Veuillez saisir votre nom : ");
string? nom = Console.ReadLine();
Console.WriteLine($"Veuillez saisir votre pérnom : ");
string? prenom = Console.ReadLine();
Console.WriteLine($"Veuillez saisir votre age :");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Bonjour {prenom} {nom}, vous avez {age} ans");