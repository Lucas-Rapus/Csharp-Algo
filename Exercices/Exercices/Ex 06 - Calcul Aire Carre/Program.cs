//Carré
Console.WriteLine($"--- Calcul du périmètre et de l'aire d'un carré ---\n");
Console.WriteLine($"Entrez la longueur d'un coté du carré (en cm) : ");
double carre = Double.Parse(Console.ReadLine());
double perimetre = carre * 4;
Console.WriteLine($"Le périmètre du carré est : {perimetre} cm");
double aircarre = Math.Pow(carre, 2);
Console.WriteLine($"L'aire du carré est : {aircarre} m²\n");

//Rectangle
Console.WriteLine($"--- Calcul du périmètre et de l'aire d'un Rectangle ---\n");
Console.WriteLine($"Entrez la longueur d'un coté du Rectangle (en cm) : ");
double longueur = Double.Parse(Console.ReadLine());
Console.WriteLine($"Entrez la Largeur d'un coté du Rectangle (en cm) : ");
double Largeur = Double.Parse(Console.ReadLine());
double perimetreRectangle = 2*(longueur + Largeur);
Console.WriteLine($"Le périmètre du Rectangle est : {perimetreRectangle} cm");
double airRect = longueur * Largeur;
Console.WriteLine($"L'aire du Rectangle est : {airRect} m²");

























