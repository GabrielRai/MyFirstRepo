
Console.WriteLine("Hur många tal vill du ange?");
int userTotal = Convert.ToInt32(Console.ReadLine()); // Tar emot ett tal av användaren.

int[] userInput = new int[userTotal]; // Skapar en array i en storlek som användaren angivit.
int y = 1;
for (int i = 0; i < userInput.Length; i++)  // Loop som tar emot de siffror som användaren vill använda. Sparas i arrayen userInput,
{
   
    Console.WriteLine("Ange tal " + y + " :");
    y++;
    userInput[i] = Convert.ToInt32(Console.ReadLine());
}
for (int l = userTotal -1; l >= 0; l-- ) // Ska loopa och skriva ut arrayen baklänges.
{
    Console.WriteLine(userInput[l]);
}
