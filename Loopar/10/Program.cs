// Be användaren mata in en sträng. Skriv ut varje tecken i strängen på en egen rad.
Console.WriteLine("Mata in ett ord");
string userInput = Console.ReadLine(); // User skriver in ett ord

char[] eachChar = userInput.ToCharArray(); // programmet tilldelar arrayen eachChar varje bokstav från userInput

foreach (char l in eachChar)
{
    Console.WriteLine(l);   // Vi utför en loop och skriver ut varje bokstav från strängen i ny rad.
}