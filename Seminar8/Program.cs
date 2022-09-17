/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

int[,] SortArray(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k<array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1)-1; j++)
            {
                if (array[i, j] < array[i, j+1])
                {
                temp = array[i,j];
                array[i,j]=array[i, j+1];
                array[i, j+1] = temp;
                }
            }
        }
    }
   return array;
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
int[,] sortArray = SortArray(array);
ShowArray(sortArray);

 */
/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

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

void MinSumRows(int[,] array)
{
    int minSumRows = 0;
    int sumMin = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumMin += array[0, j];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < sumMin)
        {
            minSumRows = i;
            sumMin = sum;
        }
    }
    Console.WriteLine($"{minSumRows} строка");
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
MinSumRows(array);

 */

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/* 
int[,] SpiralArray(int rows, int column)
{
    int[,] array = new int[rows, column];
    int i = 0;
    int j = 0;
    int rowsMin = 0;
    int rowsMax = rows - 1;
    int columnMin = 0;
    int columnMax = column - 1;
    for (int k = 1; k <= array.GetLength(0) * array.GetLength(1); k++)
    {
        array[i, j] = k;
        if (i == rowsMin && j < columnMax)
            j++;
        else if (j == columnMax && i < rowsMax)
            i++;
        else if (i == rowsMax && j > columnMin)
            j--;
        else if (j == columnMin && i > rowsMin)
            i--;

        if (i == rowsMin + 1 && j == columnMin)
        {
            rowsMin++;
            columnMax--;
            rowsMax--;
            columnMin++;
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

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов двумерного массива");
int column = Convert.ToInt32(Console.ReadLine());
int[,] array = SpiralArray(rows, column);
ShowArray(array);
 */