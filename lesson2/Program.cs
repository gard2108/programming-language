// 1) Выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа 

// void Shownumber(){
//     int num = new Random().Next(9,100);
//     int FirstNum = num / 10;
//     int SecondNum = num % 10;
//     Console.Write(num + "->");
//     if (FirstNum > SecondNum){
//         Console.Write(FirstNum);
//     }
//     else{
//         Console.Write(SecondNum);
//     }
// }

// Shownumber();

// 2)  Выводит случайное трехзначное число и удаляет вторую цифру этого числа

// int num = new Random().Next(99,1000);
//     Console.Write(num + "->");
// int DeleteTwo()
// {
//     int result = num / 100 * 10 + num % 10;
//     return result;
// }
// Console.Write(DeleteTwo());

// 3) Принять два числа и вывести, является ли второе число кратным первому
// void MultiNum(int one, int two){
// int result = Convert.ToInt32(one % two);

// if (result == 0){
//     Console.Write(one + "," + two + "-> кратно");
// }
// else{
//     Console.Write(one + "," + two + "-> не кратно, остаток" + result);
// }
// }

// Console.Write("Input number one");
// int one = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number two");
// int two = Convert.ToInt32(Console.ReadLine());

// MultiNum(one,two);

// 4) Принимает число и проверяет кратно ли оно 7 и 23 одновремменно

// void None(int num){

// if (num%7 == 0 && num%23 == 0){
//     Console.Write(num + "-> да");
// }
// else{
//     Console.Write(num + "-> нет");
// }
// }

// Console.Write("Input number");
// int num = Convert.ToInt32(Console.ReadLine());

// None (num);









// ДЗ И САМОСТОЯТЕЛЬНОЕ ЗАДАНИЕ

// 5) Принимает два числа и проверяет, является ли одно квадратом другого

// void Multi(int one,int two){
// if (one == two * two || two == one * one){
//     if (one == two * two){
//         Console.Write("первое - квадрат второго");
//     }
//     else{
//         Console.Write("второе - квадрат первого");
//     }
// }
// else{
//     Console.Write("числа не являются квадратами друг друга");
// }}

// Console.Write("input two numbers: ");
// int one = Convert.ToInt32(Console.ReadLine());
// int two = Convert.ToInt32(Console.ReadLine());

// Multi(one,two);

// 1) Принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int ResultTwo(int a)
// {
//     Console.Write (a = a % 100 / 10 );
//     return a;
// }

// Console.Write("введите число от 99 до 1000: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int result = ResultTwo(num);

// 2) Выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int Three(int a){
//     int result = -1;

//     if (a < 100 && a > -100){
//        Console.Write("третьей цифры не существует");
//        return result;
//     }
//     else{
//         return result;
        
//     }
// }

// Console.Write("введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int three = Three(num);

// 3) Принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// void weekend(int a){
//     if (a > 5 & a < 8){
//         Console.Write("это выходной день");
//     }
//     else{
//         Console.Write("это день страданий))))");
//     }
// }

// Console.Write("введите число в диапазоне [1,7] ");
// int num = Convert.ToInt32(Console.ReadLine());

//  weekend(num);





















