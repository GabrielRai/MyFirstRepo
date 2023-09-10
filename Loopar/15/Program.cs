Console.WriteLine("Mata in en text");
string userInput = Console.ReadLine();

char[] userChar = userInput.ToCharArray();
int userLast = userChar.Length - 1;

if (userChar[0] == userChar[userLast])
{
    Console.WriteLine("Du angav ett palindrom.");
}
else
{
    Console.WriteLine("Du angav inte ett palindrom.");
}
