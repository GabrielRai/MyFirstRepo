using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Skriv in en önskad uträkning. (T.ex 1 + 1)");
string userInput = Console.ReadLine();

char[] userChar = userInput.ToCharArray();















//Console.WriteLine("Skriv ett tal");
//string userInput1 = Console.ReadLine();
//int x = Convert.ToInt32(userInput1);

//string userOperator = Console.ReadLine();

//string userInput2 = Console.ReadLine();
//int y = Convert.ToInt32(userInput2);

//if (userOperator == "-")
//{
//    Console.WriteLine(x - y);

//}
//else if (userOperator == "+")
//{
//    Console.WriteLine(x + y);
//}
//else if (userOperator == "/")
//{
//    Console.WriteLine(x / y);
//}
//else if (userOperator == "*")
//{
//    Console.WriteLine(x * y);
//}






// Gör om uppgift 6 så man kan mata in allt på en rad (första talet, operator, andra talet).
// Ignorera inmatade mellanslag i strängen. Om man t.ex. matar in strängen “34 - 14”, så ska programmet skriva ut “= 20”.