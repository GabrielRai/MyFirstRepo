
Console.WriteLine("Ange ett tal");
string tal = Console.ReadLine();
int number = Convert.ToInt32(tal);
int medel = 0;
if(int.TryParse(tal, out number))
{
    Console.WriteLine(number);
    medel = number;
}
else 
{
    Console.WriteLine("exit");
}

//Skriv ett program som upprepade gånger frågar användaren efter ett tal ända
//    till man skriver något som inte är ett tal (t.ex bara trycker enter). 
//    Efter varje inmatning ska summan av alla tal som matats
//    in skrivas ut, innan nästa inmatning efterfrågas. Innan programmet avslutas ska
//    man även skriva ut medelvärde av de inmatade talen. 
//    Hint: TryParse()