using System.Drawing;
using System.Security.Cryptography;

Console.WriteLine("Skriv in en text.");
string userInput1 = Console.ReadLine();
Console.WriteLine("Skriv in en rad från förgående text");
string userInput2 = Console.ReadLine();

char[] char1 = userInput1.ToCharArray();
char[] char2 = userInput2.ToCharArray();

bool b = userInput1.Contains(userInput2);

if (b)
{
    int index = userInput1.IndexOf(userInput2);
    for (int i = 0; i < index; i++)
    {
        Console.Write(userInput1[i]);

    }
    for (int i = 0; i <= char2.Length - 1; i++) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(userInput2[i]);
        Console.ForegroundColor = ConsoleColor.White;
    }
    for (int i = char2.Length+ index; i <= userInput1.Length - 1; i++)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(userInput1[i]);

    }
}



//Gör ett program som ber användaren mata in en text. Be sedan användaren mata in en sträng som är en del av den första texten.
//Skriv ut hela texten med den del man angav markerad i en annan färg.
//    Ex. Användare matar in “abcdefghijklmnopqrstuvxyz”, och sedan “defg”. 
//    Programmet ska då skriva ut: abcdefghijklmnopqrstuvxyzTä


//1. Mata in string
//2. kolla igenom strängen efter alla delsträngar som är tal som börjar och slutar på samma.
//3. Om en bokstav hamnar emellan så är den ogiltlig.
//4.