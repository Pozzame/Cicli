Random rng = new Random();
int segreto = rng.Next(100);
Console.WriteLine("Quanti tentativi vuoi?");
int prove = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Prova un numero. (1-100)");

while (prove > 0)
{
    int num = Convert.ToInt32(Console.ReadLine());
    if (num == segreto)
    {
        Console.WriteLine("Bravo! :-D");
        prove = -1;
    }
    else if (num < segreto)
        Console.WriteLine("Prova più alto.");
    else if (num > segreto)
        Console.WriteLine("Prova più basso.");
    prove--;
}
if (prove >= 0 ) Console.WriteLine("Spiacente, hai perso. :-(");