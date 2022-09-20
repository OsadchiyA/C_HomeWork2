/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8"" */


//Ввод данных
int ReadData(string line)
{
    Console.WriteLine(line);
    int num = int.Parse(Console.ReadLine() ?? "1");
    return num;
}

//Вывод данных
void PrintData(string prefix, string num)
{
    Console.WriteLine(prefix + num);
}

//Натуральные числа по возрастанию
string NaturalNumberPos(int startNumber, int finishNumber)
{
    if (startNumber >= finishNumber)
    {
        return $"{finishNumber}";
    }
    else
    {
        return startNumber + ", " + NaturalNumberPos(startNumber + 1, finishNumber);
    }
}


//Натуральные числа по убыванию
string NaturalNumberNeg(int startNumber, int finishNumber)
{
    if (startNumber <= finishNumber)
    {
        return $"{finishNumber}";
    }
    else
    {
        return startNumber + ", " + NaturalNumberNeg(startNumber - 1, finishNumber);
    }
}

int imputM = ReadData("Введите число М: ");
int imputN = ReadData("Введите число N: ");
string outLine =
    (imputM < imputN) ? NaturalNumberPos(imputM, imputN) : NaturalNumberNeg(imputM, imputN);
PrintData("Натуральные числа в промежутке от M до N: ", outLine);
