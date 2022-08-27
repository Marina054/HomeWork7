﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9



internal class Program
{
    private static void Main(string[] args)
    {
        
        double[,] array = 
    {
        {0.5, 7, -2, -0.2},
        {1, -3.3, 8,  -9.9},
        {8, 7.8, -7,  19  },
    };
        for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                    Console.Write(array[i, j] + "   ");
                Console.WriteLine();
            }
    }
}