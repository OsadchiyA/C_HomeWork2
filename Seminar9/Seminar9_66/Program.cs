/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


//Ввод данных
int ReadData(string line)
{
    Console.WriteLine(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

//Вывод данных
void PrintData(string prefix, int num)
{
    Console.WriteLine(prefix + num);
}

//Сумма натуральных чисел
int SumNaturalNumber(int startNumber, int finishNumber)
{
    if (startNumber >= finishNumber)
    {
        return finishNumber;
    }
    else
    {
        return startNumber + SumNaturalNumber(startNumber + 1, finishNumber);
    }
}


int imputM = ReadData("Введите число М: ");
int imputN = ReadData("Введите число N: ");
int sumNaturalNumb =
    (imputM < imputN) ? SumNaturalNumber(imputM, imputN) : SumNaturalNumber(imputN, imputM);
PrintData("Сумма натуральных чисел в интервале от M до N: ", sumNaturalNumb);
