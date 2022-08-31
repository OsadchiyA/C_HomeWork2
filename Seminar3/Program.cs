/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */
/* 
string Turn (string num)
{
    int length = num.Length;
    string turnNum = null;
    for (int i = (length - 1); i >= 0 ; i--)
    {
        turnNum = turnNum + num[i];
    }
    return turnNum;
}

Console.WriteLine("Введите число");
string number = Console.ReadLine();
if (number == Turn(number))
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}


 */

/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

/* double Distance (double[] coordinates1, double[] coordinates2)
{
    double sqDistance = 0;
    for (int i = 0; i < 3; i++)
    {
        double difference = coordinates1[i] - coordinates2[i];
        sqDistance = sqDistance + Math.Pow(difference, 2);
    }
    double distance = Math.Sqrt(sqDistance);
    return distance;
}

Console.WriteLine("Введите координаты X, Y, Z первой точки");
double[] point1 = new double[3] {Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine())};
Console.WriteLine("Введите координаты X, Y, Z второй точки");
double[] point2 = new double[3] {Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine()),Convert.ToDouble(Console.ReadLine())};

Console.WriteLine($"Расстояние между точками: {Distance(point1, point2)}" ); */

/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* 
void Cube (int num)
{
    double cube = 0;
    for (int i = 1; i <= num; i++)
    {
        cube = Math.Pow(i, 3);
        Console.Write($"{cube}, ");
    }
}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Cube(number);


 */