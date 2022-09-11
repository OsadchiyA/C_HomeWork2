/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4 */

/* 
int [] CreateArray (int size)
{
    int [] array = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void ShowAmountPositNum (int[] array)
{
    int amount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) amount++;
    }
    Console.Write($"Количество  чисел больше 0 = {amount}");
}
Console.WriteLine($"Введите число M: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = CreateArray(size);
ShowAmountPositNum (array);

 */


/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

/* void CrossLine (double k1, double b1, double k2, double b2) 
{
    double abscissa = (b2-b1)/(k1-k2);
    double ordinate = k1*abscissa + b1;
    Console.WriteLine($"Точка пересечения двух прямых ({abscissa}; {ordinate})");
}


Console.WriteLine($"Введите k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите k2");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Введите b2");
double b2 = Convert.ToDouble(Console.ReadLine());
CrossLine (k1, b1, k2, b2);

 */
