Console.WriteLine("Indovina il numero");

Random rng = new Random();

int indice = 10;
while (Convert.ToBoolean(indice))
{
    Console.WriteLine(rng.Next(1000));
    indice --;
}