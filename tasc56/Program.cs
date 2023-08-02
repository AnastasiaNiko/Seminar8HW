// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
GetArray(array);
PrintArray(array);
Console.WriteLine();
MinSum(array);

int InputNum(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] newarray)
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
    {
        Console.Write($"{newarray[i, j]}\t");
    }
    Console.WriteLine();
    }
}

void GetArray(int[,] newarray)
{
    for (int i = 0; i < newarray.GetLength(0); i++)
    {
        for (int j = 0; j < newarray.GetLength(1); j++)
        {
            newarray[i, j] = new Random().Next(1 , 10);
        }
    }
}

void MinSum(int[,] array)
{
    int minrow = 0;
    int minsumrow = 0;
    int sumrow = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minrow += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumrow += array[i, j];
        if (sumrow < minrow)
        {
            minrow = sumrow;
            minsumrow = i;
        }
        sumrow = 0;
    }
    Console.Write("Номер строки с наименьшей суммой элементов " + (minsumrow + 1));
}
