//# Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int [,] GetArray(int rows, int columns)
// {
//     int [,] array = new int[rows, columns];
//     Random arrayRandomValue = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     array[i, j] = arrayRandomValue.Next(0, 10);
//                 }
//             }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write("{0,6}", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
// int [,] SortArrayRows(int [,] array)
// {
//     int temp = 0; 
//     for (int k = 0; k < array.GetLength(0); k++)
//         {
//             for (int l = 0; l < array.GetLength(1); l++)
//             {
//                 for (int i = 0; i < array.GetLength(1); i++)
//                 {
//                     for (int j = i + 1; j < array.GetLength(1); j++)
//                     {
//                         if (array[k,i] < array[k,j])
//                         {    
//                             temp = array[k,j];
//                             array[k,j] = array[k,i];
//                             array[k,i] = temp;
//                         }
//                     }
//                 }
//             }
        
//         }
//     return array;
// }

// int [,] array = GetArray(6,6);
// Console.WriteLine("Изначально заданный массив:");
// PrintArray(array);
// Console.WriteLine();
// Console.WriteLine("Элементы массива сотрированы по убыванию:");
// int [,] tempArray = SortArrayRows(array);
// PrintArray(tempArray);

// #Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// int [,] GetArray(int rows, int columns)
// {
//     int [,] array = new int[rows, columns];
//     Random arrayRandomValue = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//             {
//                 for (int j = 0; j < array.GetLength(1); j++)
//                 {
//                     array[i, j] = arrayRandomValue.Next(0, 10);
//                 }
//             }
//     return array;
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)

//         {
//             Console.Write("{0,6}", array[i, j]);
//         }
//         Console.WriteLine();
//     }
// }
// void SearchArrayRowsMinimalSum (int [,] array)
// {
//     int sumFirstString = 0;
//     int sumSecondString = 0;
//     int minString = 0;
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 sumFirstString = sumFirstString + array[i, j];
//             }

//             if (sumSecondString == 0)
//             {
//                 sumSecondString = sumFirstString;
//             }

//             if (sumFirstString < sumSecondString)
//             {
//                 sumSecondString = sumFirstString;
//                 minString = i + 1;
//             }
//             Console.WriteLine($"Сумма каждой строки {sumFirstString}");
//             sumFirstString = 0;
//         }
//     Console.WriteLine();
//     Console.WriteLine($"Строка массива с минимальным значением = {minString}");
// }
// int [,] array = GetArray(8,3);
// PrintArray(array);
// Console.WriteLine();
// SearchArrayRowsMinimalSum(array);

// #Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// void FillArray(int[,] matr, int[,] matr1)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             matr[m, n] = new Random().Next(1, 10);
//         }
//     }
//     for (int m = 0; m < matr1.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr1.GetLength(1); n++)
//         {
//             matr1[m, n] = new Random().Next(1, 10);
//         }
//     }
// }
// void PrintArray(int[,] matr, int[,] matr1)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             Console.Write($"{matr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     for (int m = 0; m < matr1.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr1.GetLength(1); n++)
//         {
//             Console.Write($"{matr1[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// void Composition(int[,] matr, int[,] matr1, int[,] compMatr)
// {
//     for (int m = 0; m < matr.GetLength(0); m++)
//     {
//         for (int n = 0; n < matr.GetLength(1); n++)
//         {
//             compMatr[m, n] = matr[m, n] * matr1[m, n];
//         }
//     }
// }
// void PrintCompArray(int[,] compMatr)
// {
//     for (int m = 0; m < compMatr.GetLength(0); m++)
//     {
//         for (int n = 0; n < compMatr.GetLength(1); n++)
//         {
//             Console.Write($"{compMatr[m, n]} ");
//         }
//         Console.WriteLine();
//     }
// }
// int[,] matrix = new int[2, 2];
// int[,] matrix1 = new int[2, 2];
// int[,] compMatrix = new int[2, 2];
// FillArray(matrix, matrix1);
// PrintArray(matrix, matrix1);
// Console.WriteLine();
// Composition(matrix, matrix1, compMatrix);
// PrintCompArray(compMatrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int [] GetOneMeasureArray (int minValue, int length)
// {
//     int [] array = new int [length];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = minValue;
//         minValue++;
//     }
//     return array;
// }
// int [,,] GetTripleArray(int depth, int rows, int columns)
// {
//     int arrayRandomIndex = 1;
//     int [] oneArray = GetOneMeasureArray(-99, 199);///Создание одномерного массива двузначных чисел:
//     int [,,] array = new int [depth, rows, columns];
//     Random randomValue = new Random();
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 for (int k = 0; k < array.GetLength(2); k++)
//                 {
//                     arrayRandomIndex = randomValue.Next(109, 198);///Положиетльные двузначные числа:
//                     if (oneArray[arrayRandomIndex] == 0)
//                     {
//                         arrayRandomIndex = randomValue.Next(10, 89);///Отрицательные двузначные числа
//                     }
//                     if (array[i, j, k] == 0)
//                     {
//                         array[i, j, k] = oneArray[arrayRandomIndex];///Значение рандомного индекса одномерного массива присваивается трёхмерному:
//                         oneArray[arrayRandomIndex] = 0;///Обнуление значения индекса в одномерном массиве:
//                         k = 0;
//                         j = 0;
//                         i = 0;
//                     }
//                 }
//             }
//         }
//     return array;
// }
// void PrintArray(int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write("{0,6}", array[i, j, k]);
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }
// void PrintIndexedArray (int [,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.WriteLine($"\n{i + 1} мерность массива:");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.WriteLine("{0,6}", $"Индекс |{i},{j},{k}|  =  ({array[i, j, k]})");
//             }
//         }
//     }
// }

// int [,,] array = GetTripleArray(3,3,6);
// Console.WriteLine();

// PrintArray(array);
// Console.WriteLine();

// Console.WriteLine("Построчная печать массива с добавлением идекса элемента:");
// PrintIndexedArray(array);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07