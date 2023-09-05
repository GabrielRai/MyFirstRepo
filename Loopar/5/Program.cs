
int sum = 0;

for(int i = 0; i < 10; i--) // Evighetsloop
{
    
    Console.WriteLine("Ange ett tal"); 
    string tal = Console.ReadLine(); // Input från användaren.
 

    if (int.TryParse(tal, out int number)) // Om stringen kan översättas till en int så körs if-satsen.
                                           // Annars så körs else kodblocket.
    {
        Console.WriteLine(number);  // Skriver ut inputen från användaren.
        int add = number;   // add håller värdet number.
        sum = sum + number; // sum lägger ihop alla tal som kommer skrivas in.

    }
    else
    {
   
        Console.WriteLine("Du angav inte ett nummer");
        Console.WriteLine(sum);     // Skriver ut summan.
        Console.WriteLine(sum / 2); //  Delar summan med två och skriver ut det.
        break;              // Avbryter evighetsloopen.
    }

}

//Skriv ett program som upprepade gånger frågar användaren efter ett tal ända
//    till man skriver något som inte är ett tal (t.ex bara trycker enter). 
//    Efter varje inmatning ska summan av alla tal som matats
//    in skrivas ut, innan nästa inmatning efterfrågas. Innan programmet avslutas ska
//    man även skriva ut medelvärde av de inmatade talen. 
//    Hint: TryParse()