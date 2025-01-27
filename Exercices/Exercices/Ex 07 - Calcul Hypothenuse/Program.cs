Console.WriteLine($"--- Calcul de la longueur de l'hyphothènuse ---");
Console.WriteLine($"Entrez la longueur du premier coté (en cm)");
double cote1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Entrez la longueur du deuxième coté (en cm)");
double cote2 = Convert.ToDouble(Console.ReadLine());
double hyp = Math.Sqrt(Math.Pow(cote1, 2) + Math.Pow(cote2, 2));

Console.WriteLine($"Hypothénuse : {Math.Round(hyp, 2)} cm");