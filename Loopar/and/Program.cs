void labb1()
{
    string value;
    do
    {
        Console.WriteLine("Enter a string that contains numbers and characters:");
        Console.ForegroundColor = ConsoleColor.Yellow;
        string input = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Gray;
        char[] numbers = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        long sequenceInt = 0;
        long sequenceSum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            string sequence = string.Empty;
            if (numbers.Contains(input[i]))
            {
                sequence += input[i];
            }
            for (int j = i + 1; j < input.Length; j++)
            {
                if (numbers.Contains(input[j]))
                {
                    sequence += input[j];
                }
                else
                {
                    break;
                }
                if (input[j] == input[i])
                {
                    int sequenceIndex = input.IndexOf(sequence);
                    string substringPre = input.Substring(0, i);
                    string substringPost = input.Substring(j + 1);
                    sequenceInt = Convert.ToInt64(sequence);
                    sequenceSum += sequenceInt;
                    if (sequenceIndex == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(substringPre);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sequence);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(substringPost);
                    }
                    if (sequenceIndex > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(substringPre);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(sequence);
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine(substringPost);
                    }
                    break;
                }
            }
        }
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sum of all sequences: " + sequenceSum);
        Console.ForegroundColor = ConsoleColor.Gray;

        Console.WriteLine("Do you want to check another sequence? y/n");
        value = Console.ReadLine();
    }
    while (value == "yes" || value == "Yes" || value == "y");
}
labb1();