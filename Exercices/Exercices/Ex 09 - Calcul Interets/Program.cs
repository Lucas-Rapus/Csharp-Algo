Console.WriteLine($"--- Calcul des intérets ---\n");
Console.WriteLine("Entrez le capital de départ (en Euros) :");
decimal capitalInitial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Entrez le taux d'intérêt (en %) :");
double tauxInteret = Convert.ToDouble(Console.ReadLine()) / 100;

Console.WriteLine("Entrez la durée de l'épargne (en années) :");
int annees = Convert.ToInt32(Console.ReadLine());

double montantInterets = (double)capitalInitial * Math.Pow(1 + tauxInteret, annees) - (double)capitalInitial;
Console.WriteLine($"Le montant des intérets sera de {montantInterets} Euros après {annees}");

double capitalFinal = (double)capitalInitial + montantInterets;
Console.WriteLine($"Le capital final sera de {capitalFinal}");
