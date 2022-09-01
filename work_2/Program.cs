// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

using System;

        
int[,] array = new int[3,4];
PrintArray(array);
DO (array);

void PrintArray (int[,]arre)
        
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = new Random().Next(9);
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
        }
}

int DO (int [,]array)
{
    int N = 4;
    
    int index = 0;
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i,j] == N)
            {    
               
               Console.WriteLine($"Число есть в массиве"+ N);
            }
            else
            {
                Console.WriteLine($"Числа нет в масиве"+ N);
            }   
        }  
    }
    return index;
}
        
        
        
        
           
           
            
            
            
            
    
            
    
            