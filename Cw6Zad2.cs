using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj rozmiar tablicy: ");
        int n = int.Parse(Console.ReadLine());

        int[,] tab = new int[n, n];
        int k = 1;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                tab[i, j] = k;
                k++;
            }
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(tab[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
