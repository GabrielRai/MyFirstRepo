Console.WriteLine("Skriv ett tal");
string userInput1 = Console.ReadLine();
int x = Convert.ToInt32(userInput1);

string userOperator = Console.ReadLine();

string userInput2 = Console.ReadLine();
int y = Convert.ToInt32(userInput2);

if (userOperator == "-")
{
    Console.WriteLine(x - y);

} 
else if (userOperator == "+")
{
    Console.WriteLine(x + y);
}
else if (userOperator == "/")
{
    Console.WriteLine(x / y);
}
else if (userOperator == "*")
{
    Console.WriteLine(x * y);
}





    //Skriv ett program som först frågar efter ett tal, sedan frågar efter ett av följande tecken: +, -, *eller /.
    //Därefter ska ytterligare ett tal efterfrågas. 
    //Programmet ska fungera som en simpel miniräknare.
    //Om man t.ex matat in först 3, sedan *, och sist 5, så ska programmet skriva ut: 3 * 5 = 15.

