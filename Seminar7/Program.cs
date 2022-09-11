/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9 */
/*
double[,] CreateRandomArray(int rows, int column, int min, int max)
{
    double[,] array = new double[rows,column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().NextDouble();
            array[i,j] *= new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива");
int max = Convert.ToInt32(Console.ReadLine());
double [,] array = CreateRandomArray(rows, column, min, max);
ShowArray(array);

 */
/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

1,7 -> такого числа в массиве нет
1,2 -> 2 */
/*

int[,] CreateRandomArray(int rows, int column, int min, int max)
{
    int[,] array = new int[rows,column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ShowElementArray(int[,] array, int rowsElement, int columnElement)
{
    if (rowsElement < array.GetLength(0) && columnElement < array.GetLength(1))
    {
        Console.WriteLine(array[rowsElement, columnElement]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomArray(rows, column, min, max);
ShowArray(array);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Введите номер строки искомого элемента двумерного массива");
int rowsElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента двумерного массива");
int columnElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
ShowElementArray(array, rowsElement, columnElement);


 */


/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

/* 
int[,] CreateRandomArray(int rows, int column, int min, int max)
{
    int[,] array = new int[rows, column];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void ShowAverageColumnArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double average = sum / array.GetLength(1);
        Console.WriteLine($"Среднее арифмитическое {i} столбца = {average}");
    }
}
Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива");
int max = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomArray(rows, column, min, max);
Console.WriteLine();
ShowArray(array);
Console.WriteLine();
ShowAverageColumnArray(array);


 */