int age = 20;
string name = "Sture";


if (age > 19)
{
    Console.WriteLine("hej");
}
else if (age > 20)
{
    Console.WriteLine("hejdå");
}
else
{
    Console.WriteLine("!");
}

int counter = 0;

while (name == "Sture")
{   
    if (counter >= 10)
    {
        break;
    }
    Console.WriteLine("LUL");
    counter++;
}

for (int i = 0; i < 10; i++)
{
    if(name != "Sture")
    {
        break;
    }
    Console.WriteLine("LOL");
}