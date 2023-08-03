// Сформируйте трёхмерный массив из случайных неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int InputNum(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
 
void GetArray(int[,,] Array)
{
  int[] temp = new int[Array.GetLength(0) * Array.GetLength(1) * Array.GetLength(2)];
  int  array;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    array = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(1, 10);
          j = 0;
          array = temp[i];
        }
          array = temp[i];
      }
    }
  }
  int count = 0; 
  for (int l = 0; l < Array.GetLength(0); l++)
  {
    for (int m = 0; m < Array.GetLength(1); m++)
    {
      for (int n = 0; n < Array.GetLength(2); n++)
      {
        Array[l, m, n] = temp[count];
        count++;
      }
    }
  }
}

void PrintArray (int[,,] Array)
{
  for (int i = 0; i < Array.GetLength(2); i++)
  {
    for (int j = 0; j < Array.GetLength(0); j++)
    {
      for (int k = 0; k < Array.GetLength(1); k++)
      {
        Console.Write($"{Array[j,k,i]}({j},{k},{i})\t ");
      }
      Console.WriteLine();
    }
  }
}

int l = InputNum("Введите количество строк: ");
int m = InputNum("Введите количество столбцов: ");
int n = InputNum("Введите количество страниц: ");
int[,,] Array = new int[l, m, n];
GetArray(Array);
PrintArray(Array);