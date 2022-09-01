// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;

        
double[,] array = new double[3,4];
PrintArray(array);
Console.WriteLine();
AverageArr(array);


void PrintArray (double[,]arre)
       
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

double AverageArr(double [,]array)
{

    double summ = 0;
    double Average=0;
    
for (double i = 0; i < array.GetLength(0)-1; i++)
{
    for ( double j = 0; j < array.GetLength(1)-3; j++)                                                        
    {
        
        summ = array[0,0] +array[1,0]+array[2,0];;
        Average = summ/array.GetLength(0);
        Console.Write(Average + ";  ");

        summ = array[0,1] +array[1,1]+array[2,1];;
        Average = summ/array.GetLength(0);
        Console.Write(Average+ ";  ");
        summ = array[0,2] +array[1,2]+array[2,2];;
        Average = summ/array.GetLength(0);
        Console.Write(Average+ ";  ");
        summ = array[0,3] +array[1,3]+array[2,3];;
        Average = summ/array.GetLength(0);
        Console.Write(Average+ ".  ");
    
       
    }
    i++;   
}
return 1;
}

