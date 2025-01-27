Console.WriteLine($"Entrez le prix HT de l'objet (en Euros) :");
double prixHT = Double.Parse(Console.ReadLine());
Console.WriteLine($"Entrez le taux de TVA (en %) : ");
double TVA = Double.Parse(Console.ReadLine());
double montantTVA = prixHT * (TVA / 100);
Console.WriteLine($"Le montant de la T.V.A est de : {montantTVA} Euros");
double prixTTC = prixHT + montantTVA;
Console.WriteLine($"Le Prix TTC de l'objet est de {prixTTC} Euros");