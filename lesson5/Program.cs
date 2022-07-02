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

int [] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for( int i = 0; i < size; i++){
         array[i] = new Random().Next(min,max + 1);} 
    return array;}

// 2) Можно заполнить с клавиатуры

// int [] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for( int i = 0; i < size; i++){
//         Console.WriteLine("введите " + i + " число");
//         array[i] = Convert.ToInt32(Console.ReadLine());} 
//     return array;}

// 3) Выводит на экран массив 

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");}}

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