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

// void ShowArray(int[] array)
// {
// Console.WriteLine();
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

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

// 1)