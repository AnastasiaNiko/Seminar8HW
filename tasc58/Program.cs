// Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int InputNum(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1 , 10);
        }
    }
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
    }
}

void NewArray(int[,] firstArray, int[,] secondArray, int[,] newArray)
{
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      newArray[i,j] = sum;
    } 
  }
}

int l = InputNum("Введите количество строк первой матрицы: ");
int m = InputNum("Введите количество столбцов первой матрицы: ");
int o = InputNum("Введите количество строк второй матрицы: ");
int n = InputNum("Введите количество столбцов второй матрицы: ");
int[,] firstArray = new int[l,m];
int[,] secondArray = new int[o, n];
int[,] newArray = new int[l, n];

PrintArray(firstArray);
PrintArray(secondArray);
GetArray(firstArray);
Console.WriteLine();
GetArray(secondArray);
NewArray(firstArray, secondArray, newArray);
Console.WriteLine();
Console.WriteLine("Результирующая матрица: ");
GetArray(newArray);