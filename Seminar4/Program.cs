/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */
/* 
void Exponentiate (int num, int exp)
{
    int result = 1;
    for (int i = 1; i <= exp; i++)
    {
        result *= num;
    }
    Console.WriteLine($"{num} в степени {exp} равно {result}");
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень, в которую необходимо возвести число");
int exponent = Convert.ToInt32(Console.ReadLine());
Exponentiate(number, exponent); */

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

/* int Sum (int num)
{
    int result = 0;
    if (num < 10)
    {
        result = 1;
    }
    else
    {
        for (int i = num; i != 0; i /= 10)
        {
        result += i % 10;
        }
    }
    
    return result;
}


Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел в числе {number} равна {Sum(number)}"); */


/* Задача 29: Напишите программу, которая задаёт массив из произвольного элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */


/* 
int[] NewArray (int length)
{
   int[] array = new int[length];
   for (int i = 0; i < length; i++)
   {
    Console.WriteLine($"Введите значение {i}-го элемента массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
   }
    return array;
}

void ShowArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.Write("]");
}


Console.WriteLine("Введите количество элементов массива");
int size = Convert.ToInt32(Console.ReadLine());

ShowArray(NewArray(size));


 */