/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

// int[,] TwoDimensionalArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] myArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);

//     return myArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] OrderingElements(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         for (int j = 0; j < array.GetLength(1); j++)
//             for (int k = 0; k < array.GetLength(1); k++)
//             {
//                 if (array[i, j] <= array[i, k]) continue;
//                 int temp = array[i, j];
//                 array[i, j] = array[i, k];
//                 array[i, k] = temp;
//             }
//     return array;
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] newArray = TwoDimensionalArray(m, n, 1, 9);
// Show2dArray(newArray);
// Show2dArray(OrderingElements(newArray));

/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

// int[,] TwoDimensionalArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] myArray = new int[m, n];

//     for (int i = 0; i < m; i++)
//         for (int j = 0; j < n; j++)
//             myArray[i, j] = new Random().Next(minValue, maxValue + 1);

//     return myArray;
// }

// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }

//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] MinimumLineAmount(int[,] array)
// {
//     int sum = int.MaxValue;
//     int index = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             temp += array[i, j];
//         }
//         if (temp < sum)
//         {
//             sum = temp;
//             index = i;
//         }
//     }
//     Console.WriteLine("Minimum line: " + index);
//     Console.WriteLine();

//     return array;
// }

// Console.Write("Input m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();
// int[,] newArray = TwoDimensionalArray(m, n, 1, 9);
// Show2dArray(newArray);
// MinimumLineAmount(newArray);

/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//     for (int i = 0; i < resultMatrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < resultMatrix.GetLength(1); j++)
//         {
//             int sum = 0;
//             for (int k = 0; k < firstMartrix.GetLength(1); k++)
//             {
//                 sum = firstMartrix[i, j] * secomdMartrix[i, j];
//             }
//             resultMatrix[i, j] = sum;
//         }
//     }
// }

// void CreateArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1, 9);
//         }
//     }
// }

// void ShowArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine("Input size matrix:");

// Console.Write("Input number of rows first matrix: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of colums first matrix and rows second: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number of colums second matrix: ");
// int p = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine("First matrix:");
// ShowArray(firstMartrix);
// Console.WriteLine();

// int[,] secondMartrix = new int[n, p];
// CreateArray(secondMartrix);
// Console.WriteLine("Second matrix:");
// ShowArray(secondMartrix);
// Console.WriteLine();

// int[,] resultMatrix = new int[m, p];
// MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
// Console.WriteLine($"Product of matrices:");
// ShowArray(resultMatrix);

/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

// void ShowArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             Console.Write($"X({i}) Y({j}) ");
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"Z({k})={array3D[i, j, k]}; ");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

// void Create3dArray(int[,,] array3D)
// {
//     int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//     int number;
//     for (int i = 0; i < temp.GetLength(0); i++)
//     {
//         temp[i] = new Random().Next(10, 100);
//         number = temp[i];
//         if (i >= 1)
//         {
//             for (int j = 0; j < i; j++)
//             {
//                 while (temp[i] == temp[j])
//                 {
//                     temp[i] = new Random().Next(10, 100);
//                     j = 0;
//                     number = temp[i];
//                 }
//                 number = temp[i];
//             }
//         }
//     }
//     int count = 0;
//     for (int x = 0; x < array3D.GetLength(0); x++)
//     {
//         for (int y = 0; y < array3D.GetLength(1); y++)
//         {
//             for (int z = 0; z < array3D.GetLength(2); z++)
//             {
//                 array3D[x, y, z] = temp[count];
//                 count++;
//             }
//         }
//     }
// }

// Console.WriteLine("Input size array X x Y x Z:");
// Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input Z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,,] array3D = new int[x, y, z];
// Create3dArray(array3D);
// ShowArray(array3D);

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

// int n = 4;
// int[,] sqareMatrix = new int[n, n];

// int temp = 1;
// int i = 0;
// int j = 0;

// while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
// {
//   sqareMatrix[i, j] = temp;
//   temp++;
//   if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
//     j++;
//   else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
//     i++;
//   else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
//     j--;
//   else
//     i--;
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       if (array[i,j] / 10 <= 0)
//       Console.Write($" {array[i,j]} ");

//       else Console.Write($"{array[i,j]} ");
//     }
//     Console.WriteLine();
//   }
// }

// Console.WriteLine($"Spiral array 4 on 4.");
// WriteArray(sqareMatrix);