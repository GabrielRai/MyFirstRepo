Console.WriteLine("Fyll i en text");

//Användaren fyller i sträng
string txt = Console.ReadLine();

//Be användaren fylla i en del av strängen
Console.WriteLine("Fyll i en del av texten");

//Användaren fyller en del av strängen
string mark = Console.ReadLine();

//gå igenom alla characters i strängen
foreach (char c in txt)
{
    for (int i = 0; i < mark.Length; i++)
    {

        //Kolla ifall strängen matchar delsträngen
        if (c == mark[i])
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(c);
            Console.ResetColor();
            break;
        }
        else
        {
            continue;
        }
    }
    Console.WriteLine(c);
}