// Задайте двумерный массив. Напишите программу, которая
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int InputNum (string text)
{
    Console.Write(text);
    return Convert.ToInt32 (Console.ReadLine ());
}

int rows = InputNum ("Введите количество строк: ");
int columns = InputNum ("Введите количество солбцов: ");

int[,] array = GetArray(rows, columns);

PrintArray(array);
Console.WriteLine();
ChangeArray(array);
PrintArray(array);

int[,] GetArray(int rows, int columns)
{
  int[,] result = new int[rows, columns];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      result[i, j] = new Random().Next(1, 20);
    }
  }
  return result;
}

void PrintArray(int[,] newArray)
{
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
      Console.Write ($"{newArray[i, j]}\t");
    }
    Console.WriteLine();
  }
}
void ChangeArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  } 
  Console.WriteLine("Упорядоченый по убыванию в строках массив: ");
  
}
