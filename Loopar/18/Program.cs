Console.WriteLine("Skriv en mening");
string userInput = "29535123p48723487597645723645";

string[] ord = userInput.Split();

for (int i = 0; i < userInput.Length; i++)
{ 
Console.WriteLine(ord[i]);
}






//Skapa en konsollapplikation som tar en textsträng (string) som argument till Main eller uppmanar användaren mata in en sträng i konsollen.
//Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
//och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
//siffror förekommer där emellan.
//ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
//ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
//t.ex 95a9 är inte heller ett korrekt tal.