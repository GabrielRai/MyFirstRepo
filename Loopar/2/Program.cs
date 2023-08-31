string losen = "pass";
Console.WriteLine("Skriv ditt lösenord:");
string pass = Console.ReadLine();



if (losen == pass)
{
    Console.WriteLine("Välkommen");
} else
{
    Console.WriteLine("Fel lösenord.");
}


//Skriv ett program som frågar användaren efter ett lösenord. 
//    Hitta på ett hemligt lösenord och spara det i en variabel. 
//    När användaren har skrivit in ett lösenord ska programmet jämföra 
//    med det sparade lösenordet och skriva ut om det var rätt eller inte. Använd en if-sats.