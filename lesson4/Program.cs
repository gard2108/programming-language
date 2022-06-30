// 1) Принимает на вход число и выдает сумму чисел от 1 до А

// int Sum(int A)
// {
//     int res = 0;
//     for(int i = 1; i < A + 1; i++ )
//     {
//         res += i;
//     }
//     Console.WriteLine(res);
//     return res;
// }

//     Console.WriteLine("введиете чилсо: ");
//     int num =Convert.ToInt32(Console.ReadLine());

//     Sum (num);

// 2) Принимает число и выдает количество цифр в нем

// int NumN ( int A)
// {
//     int res = 0;
//     for( int i = 1; A > 0; i++ ){
//         A=A/10;
//         res = i;
//     }
//     return res;
// }


// Console.WriteLine("введите число: ");
// int num =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("число имеет " + NumN(num) + " цифр");

методы для массива: 

1) Заполнен автоматически

int [] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for( int i = 0; i < size; i++)
    {
        array[i] = new Random[].Next(0,2);
    } 
    return array
}

2) Можно заполнить с клавиатуры

int [] CreateRandomArray(int size)

{
    int[] array = new int[size];
    for( int i = 0; i < size; i++)
    {
        Console.WriteLine("введите " + i " число");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
    return array
}

3) Выводит на экран массив 

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Lenght; i++)
    {
        Console.Write(Array[i] + " ");
    }
}