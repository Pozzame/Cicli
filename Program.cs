Console.WriteLine("Quante iterazioni?");
int iterazioni = Convert.ToInt32(Console.ReadLine());

Random rng = new Random();
int prove = 0;

while (Convert.ToBoolean(iterazioni))
{
    int num = rng.Next(1000);

    while(Trovatore(num) == num);
    
    iterazioni--;
}

int Trovatore(int num)
{
    while (num == rng.Next(1000))
        {
            return prova;
            prove++;
        }
}