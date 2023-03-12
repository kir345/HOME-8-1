//Задайте две матрицы. Напишите программу, которая будет 
//находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

using System;
using static System.Console;

Clear();

int[,] firstMatr = new int[2,2];
CreateArray(firstMatr);
WriteLine("Первая матрица: ");
WriteArray(firstMatr);

int[,] secondMatr = new int[2,2];
CreateArray(secondMatr);
WriteLine("Вторая матрица: ");
WriteArray(secondMatr);

int[,] resultMatr = new int[2,2];

MultiplyMatr(firstMatr, secondMatr, resultMatr);
WriteLine("Произведение первой и второй матриц: ");
WriteArray(resultMatr);

void MultiplyMatr(int[,] firstMatr, int[,] secondMatr, int[,] resultMatr)
{
  for    (int i= 0; i < firstMatr.GetLength(0); i++) 
  {
    for    (int j=0; j < secondMatr.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMatr.GetLength(1); k++)
      {
        sum += firstMatr[i,k] * secondMatr[k,j];
      }
      resultMatr[i,j] = sum;
    }
  }
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Write(array[i,j] + " ");
    }
    WriteLine();
  }
}