// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using System;
using static System.Console;
Clear();

WriteLine("Write Line: ");
int n = Convert.ToInt32(ReadLine());
WriteLine("Write colums: ");
int m = Convert.ToInt32(ReadLine());
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);

for (int i = 0; i < numbers.GetLength(1); i++)
{
    double avarage = 0;
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    WriteLine(avarage + "; ");
}

WriteLine();
PrintArray(numbers);

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        WriteLine("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            WriteLine(array[i, j] + " ");
        }
        Write("] ");
        WriteLine("");
    }
}