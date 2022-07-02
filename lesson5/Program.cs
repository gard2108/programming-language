// Примеры форматирования: 

// 1.
// String name = "имя";
// int age = 99;
// Console.WriteLine("Имя: {0}, Возраст: {1}", name, age);

// 2.
// int number = 23;
// string result = string.Format("{0:f}", number);
// Console.WriteLine(result);

// 3.
// double number2 = 45.01
// string result2 = string.Format("{0:f1}", number2);
// Console.WriteLine(result2);

// 4.
// String name = "имя";
// int age = 99;
// Console.WriteLine($"Имя: {name}, Возраст: {age}");

// 5.
// int x = 7;
// int y = 8;
// int result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// 6.
// String name = "имя";
// int age = 99;
// Console.WriteLine($"Имя: {name, -10}, Возраст: {age}"); пробелы после
// Console.WriteLine($"Имя: {name, 15}, Возраст: {age}");пробелы до


// 1) Заполнен автоматически

// int [] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//         for( int i = 0; i < size; i++)
//         {
//             array[i] = new Random().Next(min,max + 1);
//         } 
//     return array;
// }

// 2) Можно заполнить с клавиатуры

// int [] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for( int i = 0; i < size; i++){
//         Console.WriteLine("введите " + i + " число");
//         array[i] = Convert.ToInt32(Console.ReadLine());} 
//     return array;}

// // 3) Выводит на экран массив 

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// 1) Задать массив из 12 элементов, заполнить из промежутка (-9 9). Найти Сумму отриц и полож чисел

// int[] myArray = CreateRandomArray(12,-9,9);
// ShowArray(myArray);

// int pol =0;
// int otr =0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//          pol += myArray[i];
//     else
//          otr += myArray[i];
// }

// Console.WriteLine($"сумма положительных {pol} и отрицательных {otr}");

// 2) Заменяет Элементы в программе на те же но с противоположным знаком

// int[] myArray = CreateRandomArray(5,-1000,1000);
// ShowArray(myArray);

// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = -myArray[i];
// }
// Console.WriteLine("");
// ShowArray(myArray);

// 3) Определяет, присутствие числа в массиве (все сломалось но суть вроде понял)

// Console.WriteLine("введите число: ");
// int time = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(10,-1,5);
// ShowArray(myArray);

// string Check(int [] array){

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (time == myArray[i])
//     return "число есть в массиве";
// }
//  return "числа нет в массиве";
// }
// Check(myArray);





// ДЗ

// 1) Массив заполненный случайными положительными трёхзначными числами. Напишите программу,
//  которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] myArray = CreateRandomArray(8,100,1000);
// ShowArray(myArray);

// int time = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] % 2 == 0)
//         time += 1;
// }
// Console.WriteLine();
// Console.WriteLine($"в массиве {time} четных чисел");


// 2) Массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] myArray = CreateRandomArray(10,-100,100);
// ShowArray(myArray);

// int time = 0;

// for (int i = 1; i < myArray.Length; i += 2)
// {
//     time += myArray[i];
// }
// Console.WriteLine();
// Console.WriteLine(time);

// 3) Массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int[] myArray = CreateRandomArray(10,-111,111);
// ShowArray(myArray);

// int max = 0;
// int min = 0;


// for (int i = 0; i < myArray.Length; i++)
// {
//     if ( max < myArray[i])
//         max = myArray[i];
//     if ( min > myArray[i])
//         min = myArray[i];
    
// }
// Console.WriteLine();

// Console.WriteLine($"{Math.Abs(max + min)}");


// Дополнительно:
// 4) Массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] myArray = CreateRandomArray(123,0,150);
// ShowArray(myArray);

// int time = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 9 & myArray[i] < 100)
//         time++;
// }
// Console.WriteLine();
// Console.WriteLine(time);



// 5) Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int[] myArray = CreateRandomArray(9,-10,10);
// ShowArray(myArray);
// Console.WriteLine();

// for (int i = 0; i < myArray.Length; i++)
// {
//     Console.Write($"{myArray[i] * myArray[myArray.Length - i - 1]}, ");
// }








