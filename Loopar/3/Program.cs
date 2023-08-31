Console.WriteLine("Ange ett tal");
string siffra = Console.ReadLine();
int tal = Convert.ToInt32(siffra);
if (tal > 100)
{
    Console.WriteLine("Ditt tal är större än 100");
} 
else if (tal == 100)
{
    Console.WriteLine("Ditt tal är lika med 100");
} else if (tal < 100)
{
    Console.WriteLine("Ditt tal är mindre än 100");
}
//Skriv ett program som frågar användaren efter ett tal.
//Det ska skriva ut om talet är mindre än 100, lika med 100 eller större.