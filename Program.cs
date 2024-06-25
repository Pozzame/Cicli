Random rng = new Random();
int segreto = rng.Next(100);
Console.WriteLine("Quanti tentativi vuoi?");
int tentativi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prova un numero. (1-100)");

while (tentativi > 0) //prova finché non ha finito i tentativi
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num > 100)
    {
        Console.WriteLine("Sei ansato fuori range.");
        tentativi = -1; //Esce senza dire che hai perso
    }
    else if (num == segreto)
    {
        Console.WriteLine("Bravo! :-D");
        tentativi = -1; //Esce senza dire che hai perso
    }
    else if (num < segreto)
        Console.WriteLine("Prova più alto.");
    else if (num > segreto)
        Console.WriteLine("Prova più basso.");
    tentativi--;
}
if (tentativi == 0 ) Console.WriteLine("Spiacente, hai perso. :-(");