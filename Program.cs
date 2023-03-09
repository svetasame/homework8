using System;

static int Prompt(string message)
{
  System.Console.WriteLine(message);
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int[,] GenerateTwoArray(int rows, int columns)
{
  int[,] matrix = new int[rows, columns];
  Random ran = new Random();
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    System.Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      matrix[i, j] = ran.Next(1,100);
      System.Console.Write(matrix[i, j] + " ");
    }
  }
  return matrix;
}

int[,] GenerateZeroArray()
{
  int a = 0;
  int[,] matrix = new int[4, 4];
  for (int i = 0; i < 4; i++)
  {
     for (int j = 0; j < 4; j++)
    {
      matrix[i, j] = a;
    }
  }
  return matrix;
}

void PrintArrayTwo(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10)
      { System.Console.Write("0" + array[i, j] + " "); }
      else { System.Console.Write(array[i, j] + " "); }
    }
    System.Console.WriteLine();
  }
}

void SortToMinArrayTwo (int[,] array)
{
  int rows = array.GetLength(0);
  int cols = array.GetLength(1);
  int[,] sortedarray = new int[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    int[] sortedrow = new int[cols];
    for (int j = 0; j < cols; j++)
    {
      sortedrow[j] = array[i, j];
    }
    Array.Sort(sortedrow);
    Array.Reverse(sortedrow);
    System.Console.WriteLine(String.Join(" ", sortedrow));
  }
}

void PrintArray (int [] array)
{
System.Console.WriteLine(String.Join(" ", array));
}

int[] MinSummOgRowArray(int[,] array)
{
  int rows = array.GetLength(0);
  int cols = array.GetLength(1);
  int[] arraysum = new int[rows];
  for (int i = 0; i < rows; i++)
  {
    int tmp = 0;
    for (int j = 0; j < cols; j++)
    {
      tmp += array[i, j];
    }
    arraysum[i] = tmp;
  }
  return arraysum;
}

int FindMinSum(int[] array)
{
  int index = 0;
  int minsum = array[0];
  for (int k = 0; k < array.Length; k++)
  {
    if (array[k] < minsum)
    {
      minsum = array[k];
      index = k;
    }
  }
  return index + 1;
}

bool CheckMatrix (int cols1, int rows2)
{
  if (cols1==rows2)
  return true;
  else 
  return false;
}

int[,] ProductionOfMatrix(int[,] array1, int[,] array2)
{
  int rows1 = array1.GetLength(0);
  int cols1 = array1.GetLength(1);
  int rows2 = array2.GetLength(0);
  int cols2 = array2.GetLength(1);
  int[,] production = new int[rows1, cols2];
  for (int i = 0; i < rows1; i++)
  {
    for (int j = 0; j < cols2; j++)
    {
      production[i, j] = 0;
      for (int k = 0; k < rows2; k++)
      {
        production[i, j] += array1[i, k] * array2[k, j];
      }
    }
  }
return production;
}

int[,,] GenerateThreeArray(int a, int b, int c)
{
  int[,,] array = new int[a, b, c];
  Random ran = new Random();
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      // System.Console.WriteLine();
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = ran.Next(10,100);
        // System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
      }
    }
  }
  return array;
}

int[,,] GenNumber(int[,,] matrix)
{
  Random ran = new Random();
  int length = matrix.Length;
  int count = 0;
  int gennumb;
  while (count < length)
  {
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        System.Console.WriteLine();
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
          gennumb = ran.Next(10, 100);
          if (gennumb == matrix[i, j, k])
          {
            break;
          }
          else
          {
            matrix[i, j, k] = gennumb;
            System.Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) ");
            count++;
          }
        }
      }
    }
  }
  return matrix;
}

void GenerateThreeArrayAnother(int a, int b, int c)
{
  int[,,] array = new int[a, b, c];
  Random ran = new Random();
  int numb;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.WriteLine();
      for (int k = 0; k < array.GetLength(2); k++)
      {
        numb = ran.Next(10, 100);
        if (numb != array[i, j, k])
        {
          array[i, j, k] = numb;
          System.Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
        }
        else
        break;
      }
    }
  }
}

int[,] SpiralizationArray(int[,] array)
{
  int n = array.GetLength(0);
  int[,] spiral = new int[n, n];
  int i = 0, j = 0;
  int number = 1;
  while (n != 0)
  {
    int k = 0;
    do { spiral[i, j++] = number++; } while (++k < n - 1);
    for (k = 0; k < n - 1; k++) 
    {spiral[i++, j] = number++;}
    for (k = 0; k < n - 1; k++) 
    {spiral[i, j--] = number++;}
    for (k = 0; k < n - 1; k++) 
    {spiral[i--, j] = number++;}
    ++i; ++j; n = n < 2 ? 0 : n - 2;
  }
  return spiral;
}

// Задача 54: Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой 
//строки двумерного массива.
// Например, задан массив:
// 1 4 7 2

// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int rows = Prompt ("введите количество строк");
// int cols = Prompt ("введите количество столбцов");
// int [,] array1 = GenerateTwoArray (rows, cols);
// System.Console.WriteLine
// ("\nмассив с отсортированными по убыванию строками:");
// SortToMinArrayTwo (array1);


// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int rows = Prompt ("введите количество строк");
// int cols = Prompt ("введите количество столбцов");
// int [,] array1 = GenerateTwoArray (rows, cols);
// System.Console.WriteLine("\n");
// int [] sumarray = MinSummOgRowArray(array1);
// PrintArray (sumarray);
// System.Console.WriteLine
// ($"номер строки с наименьшей суммой элементов: {FindMinSum (sumarray)} строка");


// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Две матрицы можно перемножить между собой тогда и только тогда, 
// когда количество столбцов первой матрицы равно количеству 
// строк второй матрицы.


// int rows1 = Prompt ("введите количество строк 1 матрицы");
// int cols1 = Prompt ("введите количество столбцов 1 матрицы");
// int rows2 = Prompt ("введите количество строк 1 матрицы");
// int cols2 = Prompt ("введите количество столбцов 1 матрицы");
// int [,] matrix1 = GenerateTwoArray (rows1, cols1);
// System.Console.WriteLine();
// int [,] matrix2 = GenerateTwoArray (rows2, cols2);
// System.Console.WriteLine("\n");
// if (CheckMatrix (cols1, rows2) == false)
// System.Console.WriteLine("Перемножение данных матриц невозможно");
// else
// {
// int [,] production = ProductionOfMatrix (matrix1,matrix2);
// PrintArrayTwo (production);
// }


// Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int x = Prompt ("введите количество элементов в 1 измерении");
// int y = Prompt ("введите количество элементов в 2 измерении");
// int z = Prompt ("введите количество элементов в 3 измерении");
// int [,,] matrix = GenerateThreeArray(x, y, z);
// GenNumber(matrix);

// int x = Prompt ("введите количество элементов в 1 измерении");
// int y = Prompt ("введите количество элементов в 2 измерении");
// int z = Prompt ("введите количество элементов в 3 измерении");
// GenerateThreeArrayAnother(x, y, z);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// int [,] array = GenerateZeroArray();
// System.Console.WriteLine("\n");
// int [,] newarray = SpiralizationArray (array);
// PrintArrayTwo (newarray);

// Необязательное задание:
// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника - не получилось

int[][] Pascal(int n)
{
  int[][] triangle = new int[n][];
  triangle[0] = new int[] { 1 };
  for (int i = 1; i < n; i++)
  {
    triangle[i] = new int[i + 1];
    int left = 0;
    for (int j = 0; j < i; j++)
    {
      triangle[i][j] = triangle[i - 1][j] + left;
      left = triangle[i - 1][j];
    }
    triangle[i][i] = left;
  }
  for (int i = 0; i < triangle.Length; i++)
  {
    for (int j = 0; j < triangle[i].Length; j++)
    { 
    Console.Write("{0,-3}", triangle[i][j]); }
    Console.WriteLine();
  }
  return triangle;
}

Pascal(6);
