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
        Console.WriteLine("Sei andato fuori range.");
        tentativi = -1; //Esce senza dire che hai perso
    }
    else if (num == segreto)
    {
        Console.WriteLine("Bravo! :-D");
        tentativi = -1; //Esce senza dire che hai perso
    }
    else if (num < segreto)
    {
        Console.WriteLine("Prova più alto.");
        //Console.WriteLine($"Il numero è (segreto % 2 == 0 ? "pari" : "dispari")");
        if (segreto % 2 == 0) //Valuta se il resto della divisione è zero per cinsigliare se è pari o dispari
            Console.WriteLine("Il numero è pari");
        else
            Console.WriteLine("Il numero è dispari");
    }
    else if (num > segreto)
    {
        Console.WriteLine("Prova più basso.");
        if (segreto % 2 == 0) //Valuta se il resto della divisione è zero per cinsigliare se è pari o dispari
            Console.WriteLine("Il numero è pari");
        else
            Console.WriteLine("Il numero è dispari");
    }
    tentativi--;
}
if (tentativi == 0 ) Console.WriteLine("Spiacente, hai perso. :-(");