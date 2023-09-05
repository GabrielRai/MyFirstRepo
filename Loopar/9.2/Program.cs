Console.WriteLine("Nu ska vi spela Sten, Sax eller Påse. Först till tre poäng!");
Console.WriteLine("Skriv ditt val: ");
Random rnd = new Random();



string computerC = "";
int guess = 0;
int victoryUser = 0;
int victoryComp = 0;
int pointsUser = 0;
int pointsComp = 0;



while (victoryUser != 3 && victoryComp !=3)

{

    int randomComp = rnd.Next(1, 3);
    string userInput = Console.ReadLine();

    if (userInput == "Sten")
    {
        guess = 1;
    }
    else if (userInput == "Sax")
    {
        guess = 2;

    }
    else if (userInput == "Påse")
    {
        guess = 3;
    } else if(userInput == "")
    {
        Console.WriteLine("Du gjorde inget val. ");
        break;
    }

    if (randomComp == 1)
    {
        computerC = "Sten";
    }
    else if (randomComp == 2)
    {
        computerC = "Sax";
    }
    else if (randomComp == 3)
    {
        computerC = "Påse";
    }

    
    if (guess == 1 && randomComp == 1  || guess == 2 && randomComp == 2 || guess  == 3 && randomComp == 3)
    {
        Console.WriteLine("Datorn valde " + computerC);
        Console.WriteLine("Ni valde samma! Försök igen.");
    }
    else if(guess == 1 && randomComp == 2 || guess == 2 && randomComp == 3 || guess == 3 && randomComp == 1)  
    {
        Console.WriteLine("Datorn valde " + computerC);
        Console.WriteLine("Du slog datorn, bra jobbat.");
        pointsUser++;
        victoryUser++;

    }
    else if (guess == 2 && randomComp == 1|| guess == 3 && randomComp == 2 || guess == 1 && randomComp ==3)
    {
        Console.WriteLine("Datorn valde " + computerC);
        Console.WriteLine("Datorn vann, tyvärr");
        pointsComp++;
        victoryComp++;
    }
}

Console.WriteLine("Du fick " + pointsUser + " poäng och datorn fick " + pointsComp + " poäng.");