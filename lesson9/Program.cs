// Занятие 9 - рекурсия

// int Spisok(int temp, int N)
// {
//     if (temp == N) return N;
//     else 
//         temp += 1;
//         Console.Write(temp + " ");
//         return Spisok(temp, N);
// }

// Console.WriteLine("Введите Число ");
// int num = Convert.ToInt32(Console.ReadLine());

// Spisok(0, num);


// Выводит все натуральные число от M до N

// string Nums (int M, int N)
// {
// if (M == N) return M.ToString();
// return (M + " " + Nums(M + 1, N));
// }

// Console.Clear();
// Console.WriteLine("Введите Число 1 ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Число 2 ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Nums (num1,num2));




// ДЗ 

// 1) Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// int Sum ( int start, int end, int count)
// {
//     // count += 1;
//     if (start == end -1) return start - count;
//     else count += 1;
//     return ( start + 1 + Sum (start + 1, end, count));
   
// }

// Console.Clear();
// Console.WriteLine("Введите Число M ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Число N ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Sum(M,N,1));



// 2) Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman (int m,int n)
// {
//     if (m == 0) return n + 1;
//             if (n == 0)
//                 return Akkerman(m - 1, 1);
//             return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// Console.Clear();
// Console.WriteLine("Введите Число M ");
// int M = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите Число N ");
// int N = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Akkerman(M,N));



