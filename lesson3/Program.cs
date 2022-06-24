// ПРАКТИКА 3

// 1) Программа выдает принадлежность точки к четверти, в зависимости от полученных от пользователя координат

// void Chetv(int X, int Y){
//     if (X == 0 || Y == 0)
//         Console.Write("точка не принадлежит ни одной из четвертей, одна или обе координаты равны 0");
//     if (X > 0 & Y > 0)
//         Console.Write("точка принадлежит первой четверти");
//     if (X < 0 & Y > 0)
//         Console.Write("точка принадлежит второй четверти");
//     if (X < 0 & Y < 0)
//         Console.Write("точка принадлежит третьей четверти");
//     if (X > 0 & Y < 0)
//         Console.Write("точка принадлежит четвертой четверти");}
// Console.Write("Input X and Y: ");
// int X = Convert.ToInt32(Console.ReadLine());
// int Y = Convert.ToInt32(Console.ReadLine());

// Chetv(X, Y);

// 2) Программа выдает расстояние между двумя точками в 2D плоскости

// Console.Clear();
// double distAB(int x1, int y1, int x2, int y2){
//     return Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2));
// }
// Console.WriteLine("введите последовательно координаты: Ax, Ay, Bx, By, ");
// int Ax = Convert.ToInt32(Console.ReadLine());
// int Ay = Convert.ToInt32(Console.ReadLine());
// int Bx = Convert.ToInt32(Console.ReadLine());
// int By = Convert.ToInt32(Console.ReadLine());  

// Console.WriteLine("расстояние равно " + Math.Round(distAB(Ax, Ay, Bx, By),3));

// 3) Выдает список квадратов чисел от 1 до N (введенное)

// void Multi(int X){
//     int B = Math.Abs(X);

//     for (int i = 1; i < B; i++ ){
//         Console.Write(Math.Pow((i),2) + " ");
//     }}

//     Console.WriteLine("введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Multi(A);
