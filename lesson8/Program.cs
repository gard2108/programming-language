// Занятие 8

// 1) Двумерный массив заполнен автоматически

// int [,] CreateRandomDoubleArray(int m,int n, int min, int max)
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

// void ShowDoubleArray(int[,] array)
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

// 1) Программа меняет первую и последнюю строку двумерного массива местами

// int[,] arr = CreateRandomDoubleArray (5,5,-10,10);
// ShowDoubleArray(arr);

// int[,] SwapFirstAndLast (int[,] array)
// {
//     int time = 0;
//     for (int i = 0; i < array.GetLength(0); i += array.GetLength(0))
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             time = array[i,j];
//             array[i,j] = array[i + array.GetLength(0) - 1,j];
//             array[i + array.GetLength(0) - 1,j] = time;
//         }
//     }
//     return array;
// }

// SwapFirstAndLast (arr);
// ShowDoubleArray(arr);


// 2) Заменяет строки на столбцы, если это невозможно - оповещает пользователя

// int[,] SwapRawsAndColums (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = array[j,i];
//         }
//     }
//     return array;
// }


// int m = new Random().Next(4,6);
// int n = new Random().Next(4,6);

// Console.WriteLine($"{m}, {n}");
// int[,] arr = CreateRandomDoubleArray (m,n,0,10);
// ShowDoubleArray(arr);

// if (m != n) { Console.WriteLine("замена строк столбцами невозможна");}
// else{
//     int[,] NewArr = arr;
//     SwapRawsAndColums(NewArr); 
//     ShowDoubleArray(NewArr);}



// 3)счетчик повторяющихся элементов массива

// int[,] arr = CreateRandomDoubleArray (3,3,0,10);
// ShowDoubleArray(arr);

// int [] GetOneArr (int[,] array)
// {
//     int ind = 0;
//     int[] arrone = new int [arr.GetLength(0) * arr.GetLength(1)];

//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for( int j = 0; j < arr.GetLength(1); j++)
//         {
//             arrone[ind] = arr[i,j];
//             ind++;
//         } 
//     }
//     return arrone;
// }

// void SortArray(int[] array)
// {
//     int max = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         for (int j = i + 1; j < array.Length; j++)
//         {
//             if(array[i] > array[j])
//             {
//                 int buf = 0;
//                 buf = array[i];
//                 array[i] = array[j];
//                 array[j] = buf;
//             }
//         }
//     }
// }
// int[] array =GetOneArr(arr);
// Console.WriteLine(String.Join(" ",array));

// SortArray(array);
// Console.WriteLine(String.Join(" ",array));

// void Print(int[] array)
// {
//     int count = 0;
//     int temp = array[1];
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] != temp)
//         {
//             Console.WriteLine($"{temp} встречается {count} раз ");
//             temp = array[i];
//             count =  1;
//         }
//         else
//         {
//             count++;
//         }
//     }
//     Console.WriteLine($"{temp} встречается {count} раз ");
// }

// Print(array);










// ДЗ



int [,] CreateRandomDoubleArray(int m,int n, int min, int max)
{
    int[,] array = new int[m,n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min,max + 1);
        } 
    }
    return array;
}


void ShowDoubleArray(int[,] array)
{
Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}



// 1) Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

// int[,] arr = CreateRandomDoubleArray (5,5,-10,10);
// ShowDoubleArray(arr);

// int[,] Down(int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 1; j < array.GetLength(1); j++)
//         {
//             int temp = 0;
//             if (array[i,j] > array[i,j - 1])
//             {
//                 temp = array[i,j];
//                 array[i,j] = array[i,j - 1];
//                 array[i,j - 1] = temp;
//                 j = 0;
//             }
//         }
//     } 
//     return array;
// }            

// Down (arr);
// ShowDoubleArray(arr);


// 2) Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// int[,] arr = CreateRandomDoubleArray (4,6,-10,5);
// ShowDoubleArray(arr);

// int MinRaws (int [,] array)
// {
//     int next = 0;
//     int temp = 0;
//     int raw = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             next += array[i,j];
//         }
//         if (i == 0)
//             {
//                 temp = next;
//                 raw = i + 1;
//             }
//             if ( next < temp && i > 0)
//             {
//                 temp = next;
//                 raw = i + 1;
//             }
//             next = 0;
//     }
//     return raw;
// }

// int end = MinRaws(arr);
// Console.WriteLine($"в {end} строке наименьшая сумма элементов");




// 3) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// int [,] dubble ( int [,] array1, int[,] array2, int m, int n)
// {
//     int [,] array = new int[m,n];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < m + 1; k++)
//             {
//                 array[i,j] = array[i,j] + array1[i,k] * array2[k,j];
//             }
//         }
//     }
//     return array;
// }

// int m1 = 2;
// int n1 = 5;

// int m2 = 5;
// int n2 = 3;

// int[,] arr1 = CreateRandomDoubleArray (m1,n1,1,3);
// ShowDoubleArray(arr1);

// int[,] arr2 = CreateRandomDoubleArray (m2,n2,1,5);
// ShowDoubleArray(arr2);

// int[,] arr = dubble(arr1, arr2, m1, n2);
// ShowDoubleArray(arr);




// 4) Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.






// 5) Заполните спирально массив 4 на 4.






// 6) Задайте двумерный массив из целых чисел. Напишите программу,
//  которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.






// 7) Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника






