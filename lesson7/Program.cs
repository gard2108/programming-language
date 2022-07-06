// 1) Двумерный массив заполнен автоматически
int [,] CreateRandomDubbleArray(int m,int n, int min, int max)
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


// 2) Двумерный массив выводится на экран массив 

void ShowDubbleArray(int[,] array)
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