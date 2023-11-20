// ﻿﻿// Задача 54: Задайте двумерный массив. Напишите программу, 
// // которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }


// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }

// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// static void QuickRowSort(int[,] matrix, int row, int first, int last) 
// //модифицироанный метод быстрой сортировки для одного ряда матрицы
// {
//     int i = first;
//     int j = last;
//     int pivot = (first + last) / 2; //выбираем опорный элемент
//     while (i < j) // идем по i с начала, по j с конца, находим слева 
//     // элемент больше arr[pivot] а справа меньше и обмениваем их
//     {
//         while (matrix[row, i] > matrix[row, pivot]) //для сортировки по убыванию меняем знак
//         {
//             i++;
//         }
//         while (matrix[row, j] < matrix[row, pivot]) //для сортировки по убыванию меняем знак
//         {
//             j--;
//         }
//         if (i <= j)
//         {
//             int temp = matrix[row, i];
//             matrix[row, i] = matrix[row, j];
//             matrix[row, j] = temp;
//             i++;
//             j--;
//         }
//     }
//     // рекурсивно применяем к массивам справа и слева от места встречи i и j
//     if (first < j) QuickRowSort(matrix, row, first, j);
//     if (i < last) QuickRowSort(matrix, row, i, last);
// }

// void MatrixRowSort(int[,] matrix) // пробегаем по рядам матрицы и сортируем каждый из них
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         QuickRowSort(matrix, i, 0, matrix.GetLength(1)-1);
//     }
// }

// int n = ReadData("Введите количество строк: ");
// int m = ReadData("Введите количество строк: ");
// int[,] matrix = Fill2DArray(n, m, 10, -10); // задаем матрицу
// Console.WriteLine("Исходный массив:");
// Print2DArray(matrix); // выводим исходный массив
// Console.WriteLine("Массив с отсортированными строками:");
// MatrixRowSort(matrix); //производим сортировку по рядам
// Print2DArray(matrix); // выводим отсортированный массив

// Введите количество строк: 
// 5
// Введите количество строк: 
// 5
// Исходный массив:
// -10 3 3 8 2
// 10 10 7 -2 -10
// 4 -6 -9 -3 -1
// -2 -2 -2 -3 -3
// 2 6 -2 2 5
// Массив с отсортированными строками:
// 8 3 3 2 -10
// 10 10 7 -2 -10
// 4 -1 -3 -6 -9
// -2 -2 -2 -3 -3
// 6 5 2 2 -2


// ﻿// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// // которая будет находить строку с наименьшей суммой элементов.



// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// // Заполнение матрицы
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }

// //Вывод матрицы на экран
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// //Поиск ряа с минимальной суммой
// int FindRowMinSum(int[,] matrix, ref int minSum)
// {
//     minSum = 0; // обнуляем сумму
//     int rowMinSum = 0; // задаем ряд, для первого сравнения

//     for (int j = 0; j < matrix.GetLength(1); j++) // накапливаем сумму его членов в minSum
//     {
//         minSum += matrix[rowMinSum, j];
//     }

//     // проходим остальные ряды 
    
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     {
//         int rowSum = 0;
//         //получаем сумму их членов
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             rowSum += matrix[i, j];
//         }
//         //сравниваем с предыдущей найденой минимальной
//         if (rowSum < minSum)
//         {
//             // если меньше, то берем эту сумму как минимальную
//             minSum = rowSum;
//             rowMinSum = i;
//         }
//     }
//     return rowMinSum;
// }

// int n = ReadData("Введите количество строк");
// int m = ReadData("Введите количество столбцов");
// int[,] matrix = Fill2DArray(n, m, 10, -10); // задаем матрицу
// Console.WriteLine("Исходный массив:");
// Print2DArray(matrix); // выводим исходный массив
// int minSum = 0;
// int rowMinSum = FindRowMinSum(matrix, ref minSum); // ищем минимальные ряд и его сумму
// Console.WriteLine($"Номер ряда с минимальной суммой: {rowMinSum}. Сама сумма равна {minSum}");

// ﻿// Задача 58: Задайте две матрицы. Напишите программу, 
// // которая будет находить произведение двух матриц.
// // Например, даны 2 матрицы:
// // 2 4 | 3 4
// // 3 2 | 3 3
// // Результирующая матрица будет:
// // 18 20
// // 15 18

// int ReadData(string msg) // вводим данные
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// // Заполнение матрицы
// int[,] Fill2DArray(int countRow, int countColumn, int topBorder, int downBorder)
// {
//     int[,] array2D = new int[countRow, countColumn];
//     for (int i = 0; i < countRow; i++)
//     {
//         for (int j = 0; j < countColumn; j++)
//         {
//             array2D[i, j] = new Random().Next(downBorder, topBorder + 1);
//         }
//     }
//     return array2D;
// }

// //Вывод матрицы на экран
// void Print2DArray(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             Console.Write(matrix[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// int rowOnColumn(int[,] matrix1, int[,] matrix2, int row, int column) 
// // произведение одной строки на один стоблец
// {
//     int sum = 0;
//     for(int i = 0; i < matrix1.GetLength(1); i++)
//     {
//         sum += matrix1[row,i]*matrix2[i,column];
//     }
//     return sum;
// }

// int[,] MatrixProduct(int[,] matrix1, int[,] matrix2)
// {   //определяем размер результирующей матрицы
//     int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     for (int i = 0; i < result.GetLength(0); i++)
//     {
//         for (int j = 0; j < result.GetLength(1); j++)
//         {
//             result[i,j] = rowOnColumn(matrix1, matrix2, i, j);
//         }
//     }
//     return result;
// }

// Console.Clear();
// int n = ReadData("Введите количество строк первой матрицы");
// int m = ReadData("Введите количество столбцов первой матрицы");
// int[,] matrix1 = Fill2DArray(n, m, 10, -10); // задаем первую матрицу из n строк и m столбцов
// int[,] matrix2 = Fill2DArray(m, n, 10, -10); // задаем вторую матрицу, чтобы не усложнять из m строк и n столбцов
// Console.WriteLine("Первая матрица: ");
// Print2DArray(matrix1); // выводим первую матрицу
// Console.WriteLine("Вторая матрица: ");
// Print2DArray(matrix2); // выводим вторую матрицу
// int[,] resMatrix = MatrixProduct(matrix1,matrix2);
// Console.WriteLine("Матрица произведение: ");
// Print2DArray(resMatrix); // выводим матрицу - произведение


// // Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// // которая будет построчно выводить массив, добавляя индексы каждого элемента.

// int[,,] array3D = new int[2, 2, 2];
// FillArray(array3D);
// PrintIndex(array3D);


// // Функция вывода индекса элементов 3D массива
// void PrintIndex(int[,,] arr)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.WriteLine();
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
//             }
//         }
//     }
// }

// // Функция заполнения 3D массива не повторяющимеся числами
// void FillArray(int[,,] arr)
// {
//     int count = 10;
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             for (int k = 0; k < arr.GetLength(2); k++)
//             {
//                 arr[k, i, j] += count;
//                 count += 3;
//             }
//         }
//     }
// }

// ﻿// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// int len = 4;
// int[,] table = new int[len, len];
// FillArraySpiral(table, len);
// PrintArray(table);


// //  Функция заполнения массива по спирали начиная с 1
// void FillArraySpiral(int[,] array, int n)
// {
//     int i = 0, j = 0;
//     int value = 1;
//     for (int e = 0; e < n * n; e++)
//     {
//         int k = 0;
//         do { array[i, j++] = value++; } while (++k < n - 1);
//         for (k = 0; k < n - 1; k++) array[i++, j] = value++;
//         for (k = 0; k < n - 1; k++) array[i, j--] = value++;
//         for (k = 0; k < n - 1; k++) array[i--, j] = value++;
//         ++i; ++j;
//         n = n < 2 ? 0 : n - 2;
//     }
// }

// //  Функция вывода двумерного массива в терминал
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] < 10)
//             {
//                 Console.Write("0" + array[i, j]);
//                 Console.Write(" ");
//             }
//             else Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }