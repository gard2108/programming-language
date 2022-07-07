// Занятие 8

// 1) Двумерный массив заполнен автоматически

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


// 2) Двумерный массив выводится на экран массив 

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

int[,] arr = CreateRandomDoubleArray (3,3,0,10);
ShowDoubleArray(arr);

int [] GetOneArr (int[,] array)
{
    int ind = 0;
    int[] arrone = new int [arr.GetLength(0) * arr.GetLength(1)];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for( int j = 0; j < arr.GetLength(1); j++)
        {
            arrone[ind] = arr[i,j];
            ind++;
        } 
    }
    return arrone;
}

void SortArray(int[] array)
{
    int max = 0;
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[i] > array[j])
            {
                int buf = 0;
                buf = array[i];
                array[i] = array[j];
                array[j] = buf;
            }
        }
    }
}
int[] array =GetOneArr(arr);
Console.WriteLine(String.Join(" ",array));

SortArray(array);
Console.WriteLine(String.Join(" ",array));

void Print(int[] array)
{
    int count = 0;
    int temp = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] != temp)
        {
            Console.WriteLine($"{temp} встречается {count} раз ");
            temp = array[i];
            count =  1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{temp} встречается {count} раз ");
}

Print(array);
