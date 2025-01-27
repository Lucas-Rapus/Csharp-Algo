Console.WriteLine($"--- la lettre est-elle une voyelle ? ---");
string voyelle = Console.ReadLine().ToUpper();

if (voyelle == "A" ||
    voyelle == "E" ||
    voyelle == "I" ||
    voyelle == "O" ||
    voyelle == "U" ||
    voyelle == "Y")
{
    Console.WriteLine("Cette lettre est une voyelle"); 
}
else
{
    Console.WriteLine("Cette lettre n'est pas une voyelle");
}