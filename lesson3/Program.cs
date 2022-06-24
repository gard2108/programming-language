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








// ДЗ

// 1) Принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void Swap(int A){
//     if (A/10000 == A%10 & A/1000 % 10 == A/10%10){
//         Console.Write("Число - палиндром");
//     }
//     else{
//         Console.Write("Число -не палиндром");
//     }}

// Console.Write("введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Swap(num);

// int A = 12345;
// Console.Write (A/1000%10);

// 2) Принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// int Pyt(int Ax,int Ay,int Az,int Bx,int By,int Bz){
//     int res = Convert.ToInt32(Math.Abs(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2) + Math.Pow((Bz-Az),2)));
//     Console.Write("длина отрезка равна " + res);

//     return res;
// }
// Console.WriteLine("последовательно введите кординаты точки а (x,y,z) и точки b (x,y,z)");

// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine()); 
// int e = Convert.ToInt32(Console.ReadLine());
// int f = Convert.ToInt32(Console.ReadLine());

// int done = Pyt(a, b, c, d, e, f);

// 3) Принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Tri(int num){
//     for( int i=1; i<num; i++){
//         Console.Write(Math.Pow((i),3) + " ");
// }}

// Console.WriteLine("введите любое положительное число число: ");
// int A = Convert.ToInt32(Console.ReadLine());

// Tri(A);

