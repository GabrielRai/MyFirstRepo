
using System.ComponentModel;
using System.Net.Sockets;
using System.Numerics;
Console.WriteLine("Välkommen, mata in en text rad som du vill kolla efter matchningar.");
string userText = Console.ReadLine();
Console.WriteLine();

char[] chars = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9'};
Int64 sum = 0;
Int64 value;
for (int i = 0; i < userText.Length; i++)
{
    string one = String.Empty;
    if (chars.Contains(userText[i]))
    {
        one += userText[i];
    }

    for (int j = i + 1; j < userText.Length; j++)
    {
        if (chars.Contains(userText[j]))
        {
            one += userText[j];
            
        } 
        else
        {
            break;
        }
       
        if (userText[j] == userText[i])
        {
            
            int startIndex = 0;
            int endIndex = i;
            string s1 = userText.Substring(startIndex, endIndex);

            int startIndex2 = j + 1;
            int endIndex2 = userText.Length - 1;
            string s2 = userText.Substring(startIndex2, endIndex2 - j);

            Console.Write(s1);
            Console.ForegroundColor = ConsoleColor.Green; 
            Console.Write(one);
            Console.ForegroundColor= ConsoleColor.White;
            Console.WriteLine(s2);

            value = Convert.ToInt64(one);
            sum += value;

            break;
        }
    }
}

Console.WriteLine();
Console.WriteLine("Input av användare: " + userText);
Console.WriteLine("Summan av alla matchade tal: " + sum);

