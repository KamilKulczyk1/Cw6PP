﻿using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] tab = new int[10, 10];
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = i * 10 + j + 1;
                }
            }
            else
            {
                for (int j = 9; j >= 0; j--)
                {
                    tab[i, j] = i * 10 + (9 - j) + 1;
                }
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(tab[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
