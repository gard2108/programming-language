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

// методы для массива: 

// 1) Заполнен автоматически

// int [] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for( int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min,max + 1);
//     } 
//     return array
// }

// 2) Можно заполнить с клавиатуры

// int [] CreateRandomArray(int size)

// {
//     int[] array = new int[size];
//     for( int i = 0; i < size; i++)
//     {
//         Console.WriteLine("введите " + i + " число");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     } 
//     return array;
// }

// 3) Выводит на экран массив 

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }






// ДЗ 

// 1) Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 6, 3 -> 243 (3⁵)

// int Vosv(int A, int B)
// {
//     int res = 1;
//     for(int i =  1; i <= B; i++ )
//     {
//         res = res * A;
//     }
//     return res;
// }

// Console.WriteLine("последовательно введите 2 числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Vosv(num1,num2));


// 2) Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11

// int Sum(int A)
// {
//     int time = A;
//     int res = 0;
//     for (int i = 1; A > 0; i++)
//     {
//         time = A % 10; 
//         A = A / 10;
//         res += time;
//     }

//     return res;
// }

// Console.WriteLine(" введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("сумма цифр числа = " + Sum(num));


// 3) Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// int [] CreateRandomArray(int size)

// {
//     int[] array = new int[size];
//     for( int i = 0; i < size; i++)
//     {
//         Console.WriteLine("введите " + i + " число");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     } 
//     return array;
// }

//  void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(CreateRandomArray(8));


