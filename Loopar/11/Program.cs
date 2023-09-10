// See https://aka.ms/new-console-template for more information
Console.WriteLine("Skriv en siffra");
string[] numbers = {"noll","ett","två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio" };

int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numbers[userNumber]);