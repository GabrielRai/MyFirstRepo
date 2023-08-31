
Console.WriteLine("Hej, vad heter du?");
string namn = Console.ReadLine();
string namnEtt = namn;

if(namn == "David")
{
    Console.WriteLine("Hej David");
    Console.WriteLine("Skriv ett tal");

    string inputTal = Console.ReadLine();
    int tal = Convert.ToInt32(inputTal);

    for (int i = 1; i <= tal; i++)
    {
        Console.WriteLine("Hej David");
 
    }
} else
{
    Console.WriteLine(".");
}



