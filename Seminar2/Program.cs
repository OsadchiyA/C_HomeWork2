/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
 */
/* int SecondNumber (int num)
{     
    int snum = (num % 100) / 10;
    return snum;
}


Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99  && number < 1000)
    {
        Console.WriteLine(SecondNumber(number));
    }
    else
    {
        Console.WriteLine("Число не является трехзначным");
    }



 */

/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6 */
/* 
string ThirdNumber (string num)
{
    string third;
    int lengthNum = num.Length;
    if (lengthNum >= 3)
    {
        third = num.Substring(2,1);
    }
    else
    {
        third = "Третьей цифры нет";
    }
    return third;
}


Console.WriteLine("Введите число");
string number = Console.ReadLine();
Console.WriteLine(ThirdNumber(number));
 */

/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */

/* void Weekend (int num)
{
    if (num == 6 || num == 7)
    {
        Console.WriteLine("ДА");
    }
    else if (num >= 1 && num <= 5)
    {
        Console.WriteLine("НЕТ");
    }
    else
    {
        Console.WriteLine("Неверное число");
    }
}


Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
Weekend(day);


 */