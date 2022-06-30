// 1) Принимает на вход число и выдает сумму чисел от 1 до А

int Sum(int A)
{
    int res = 0;
    for(int i = 1; i < A + 1; i++ )
    {
        res += i;
    }
    Console.WriteLine(res);
    return res;
}

    Console.WriteLine("введиете чилсо: ");
    int num =Convert.ToInt32(Console.ReadLine());

    Sum (num);