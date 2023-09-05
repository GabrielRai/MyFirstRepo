
using System;
using System.Reflection.Metadata.Ecma335;
Random rnd = new Random();
int randomNumber = rnd.Next(1, 100);
int victory = 0;
int guess = 0;

while (victory != 1)  {

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Ange ett tal mellan 1-100");
    string userInput = Console.ReadLine();
    int uI = Convert.ToInt32(userInput);
    
    

    if (uI < randomNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Din gissning är för låg");
        guess++;

    }
    else if (uI > randomNumber)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Din gissning är för hög");
        guess++;


    }
    else if (uI == randomNumber)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Du gissade rätt! Bra jobbat!");
        guess++;
        Console.WriteLine("Antal gissningar: " + guess);
        victory++;
    }
}