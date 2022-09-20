/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */




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

//Значение функции Аккермана
int AkkermanFunction(int NumberM, int NumberN)
{
    if (NumberM == 0)
    {
        return NumberN + 1;
    }
    else if (NumberM > 0 && NumberN == 0)
    {
        return AkkermanFunction(NumberM - 1, 1);
    }
    else
    {
        return AkkermanFunction(NumberM - 1, AkkermanFunction(NumberM, NumberN - 1));
    }
}

int imputM = ReadData("Введите число m: ");
int imputN = ReadData("Введите число n: ");
int valueAkkerman = AkkermanFunction(imputM, imputN);
PrintData($"Значение функции Аккермана для чисел m = {imputM} и n = {imputN}: ", valueAkkerman);
