// 1) Заполнен автоматически

int [] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
        for( int i = 0; i < size; i++)
        {
            array[i] = new Random().Next(min,max + 1);
        } 
    return array;
}

// 2) Можно заполнить с клавиатуры

// int [] CreateRandomArray(int size){
//     int[] array = new int[size];
//     for( int i = 0; i < size; i++){
//         Console.WriteLine("введите " + i + " число");
//         array[i] = Convert.ToInt32(Console.ReadLine());} 
//     return array;}

// 3) Выводит на экран массив 

void ShowArray(int[] array)
{
Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// 1) Переворачивает Массив


// int[] arr = CreateRandomArray(10,-100,100);
// ShowArray(arr);
// int time = 0;

// for (int i = 0; i < arr.Length/2; i++)
// {
//     time = arr[i];
//     arr[i] = arr[arr.Length - i - 1];
//     arr[arr.Length - i - 1] = time;
// }

// ShowArray(arr);

// 2) Получает на вход 3 числа и проверяет может ли существовать треугольник с такими сторонами

// bool Treyg(double A, double B, double C)
// {
//     if (A + B > C & A + C > B & B + C > A)
//         return true;
//     else 
//         return false;
// }

// double x = new Random().NextDouble();
// Console.WriteLine("{0:f5}",x);
// double y = new Random().NextDouble();
// Console.WriteLine("{0:f5}",y);
// double z = new Random().NextDouble();
// Console.WriteLine("{0:f5}",z);

// Console.WriteLine("введите предполагаемые величины сторон треугольника ");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int C = Convert.ToInt32(Console.ReadLine());

// if (Treyg(x, y, z))
//     Console.WriteLine("треугольник есть");
// else
//     Console.WriteLine("треугольника нет");







// ДЗ

// 1)Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

// int count = 0;
 
// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }
 
// Console.WriteLine($"Кол-во элементов > 0 = {count}");



// 2) Преобразовывает десятичное число в двоичное.
// 45 -> 101101

// void two(int A)
// {
//     Console.WriteLine("двоичное число имеет вид: ");
//     for (int i = 0; A > 0; i++)
//     {
//         Console.Write($"{A % 2}");
//         A /= 2;
//     }
// }

//  Console.WriteLine("десятичное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// two(num);




// 3) Находит точку пересечения двух прямых, заданных уравнениями:



// void pr( int k1,int b1,int k2,int b2)
// {
//     int x = 0;
//     int y = 0;
//     x = (b2 - b1) / (k1 - k2);
//     y = k2 * ((b2 - b1) / (k1 - k2)) + b2;
    
//     Console.WriteLine($"координаты точки пересечения: ({x};{y})");
// }

// Console.WriteLine("последовательно введите k1 b1 k2 b2 (k1 не равно k2), принадлежащих уравнениям прямых вида y = k1x + b1, y = k2x + b2 ");
// int A = Convert.ToInt32(Console.ReadLine());
// int B = Convert.ToInt32(Console.ReadLine());
// int C = Convert.ToInt32(Console.ReadLine());
// int D = Convert.ToInt32(Console.ReadLine());

// pr(A, B, C, D);

// 4) Введит первые N чисел Фибоначчи
// Если N = 5 -> 0 1 1 2 3

// void Fib(int A)
// {
//     int[] arr = new int[A];
//     arr[0] = 0;
//     arr[1] = 1;

//     for (int i = 2; i < arr.Length; i++)
//     {
//         arr[i] = arr[i - 1] + arr[i -2];
//     }
// ShowArray(arr);
// }

// Console.WriteLine("введите число, сколько первых чисел фибоначи нужно вывести: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Fib(num);

