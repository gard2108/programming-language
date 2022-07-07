// 1) Двумерный массив заполнен автоматически

// int [,] CreateRandomDubbleArray(int m,int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(min,max + 1);
//         } 
//     }
//     return array;
// }


// 2) Двумерный массив выводится на экран массив 

// void ShowDubbleArray(int[,] array)
// {
// Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// 1) Первое задание

// Console.WriteLine("Введите количество строк: ");
// int raws = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Минимальное число в массиве: ");
// int raws = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Максимальное число в массиве: ");
// int columns = Convert.ToInt32(Console.ReadLine());


// int[,] arr = CreateRandomDubbleArray (raws, columns, min, max);
// ShowDubbleArray(arr);


// 2) Второе Задание

// int[,] CreateDubbleArray(int m,int n)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = i + j;
//         } 
//     }
//     return array;
// }

// Console.WriteLine("Введите количество строк: ");
// int raws = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arr = CreateDubbleArray(raws, columns);
// ShowDubbleArray(arr);

// 3) 3 задача

// int[,] arr = CreateRandomDubbleArray (5,5,-10,10);
// ShowDubbleArray(arr);

// int [,] DubbleChetInex (int [,] array)
// {
//     for (int i = 2; i < array.GetLength(0); i +=2)
//     {
//         for (int j = 2; j < array.GetLength(1); j += 2)
//         {
//             array[i,j] = array[i,j] * array[i,j];
//         }
//     }
//     return array;
// }

// int [,] end = DubbleChetInex (arr);
// ShowDubbleArray(end);

// 4) Найти сумму элементов в главной диагонали массива (1,1), (2,2) и тд

// int [,] arr = CreateRandomDubbleArray(5,5,0,5);
// ShowDubbleArray(arr);

// int time = 0;

// for (int i = 0; i < arr.GetLength(0); i++)
// {
//     for (int j = i; j < arr.GetLength(1); j = j + arr.GetLength(1))
//     {
//         time += arr[i,j];
//     }
// }

// Console.WriteLine(time);






// ДЗ 

// 1) Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2

// double[,] CreateRandomDubbledoubleArray(int m,int n)
// {
//     double[,] array = new double[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for( int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().NextDouble();
//         } 
//     }
//     return array;
// }

// void ShowDubbledoubleArray(double[,] array)
// {
// Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
            // Console.Write($"{array[i,j]:f1} ");
//         }
//         Console.WriteLine();
//     }
// }

// double [,] arr = CreateRandomDubbledoubleArray(3,4);
// ShowDubbledoubleArray(arr);



// 2) На вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 1, 7 -> такого числа в массиве нет

// int m = 5;
// int n = 5;

// int [,] arr = CreateRandomDubbleArray (m,n,-10,10);
// ShowDubbleArray(arr);

//  Console.WriteLine("введите индексы нужного элемента массива: ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// int n1 = Convert.ToInt32(Console.ReadLine());

// if (m1 > m || n1 > n)  Console.WriteLine("этого элемента массива не существует");
// else  Console.WriteLine(arr[m1,n1]);



// 3) Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// int [,] CreateRandomDubbleArray(int m,int n, int min, int max)
// {
// int[,] array = new int[m,n];
// for (int i = 0; i < array.GetLength(0); i++)
//     {
// for( int j = 0; j < array.GetLength(1); j++)
//         {
// array[i,j] = new Random().Next(min,max + 1);
//         } 
//     }
// return array;
// }

// void ShowDubbleArray(int[,] array)
// {
// Console.WriteLine();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
// for (int j = 0; j < array.GetLength(1); j++)
//         {
// Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }


// int[,] arr = CreateRandomDubbleArray(5,5,0,5);
// ShowDubbleArray(arr);

// double time = 0;
//  int num =0;

// for (int j = 0; j < arr.GetLength(0); j++)
// {
// for (int i = 0; i < arr.GetLength(1); i++)
//     {
// time += arr [i,j];
// num = i + 1;
//     }
// Console.Write(time/num + " ");
// time = 0;
// }