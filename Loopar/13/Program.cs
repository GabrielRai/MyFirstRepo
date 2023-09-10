using System.ComponentModel;

Console.WriteLine("Skriv en text");
string userInput = Console.ReadLine();
char[] userString = userInput.ToCharArray();
Array.Reverse(userString);
string reversedString = new string(userString);
Console.WriteLine(reversedString);


    