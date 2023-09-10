// See https://aka.ms/new-console-template for more information
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Skriv en text!");
string userInput = Console.ReadLine();
char[] userText = userInput.ToCharArray();

for (int i = 0; i < userText.Length; i++)
{
    char c = userText[i];
    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y' || c == 'å' || c == 'ä' || c == 'ö')
    {
        userText[i] = '*';
    } 
   
}   

Console.WriteLine(userText);




// Be användaren mata in en text. Skriv ut texten med alla vokaler ersatta med *

// 1: Console.ReadLine();
// gör om strängen till char
// spara ner i en array
// kolla i arrayen om någon av charen är en vokal
// ersätt med *

// Vokalerna i svenskan är: a, e, i, o, u, y, å, ä och ö.