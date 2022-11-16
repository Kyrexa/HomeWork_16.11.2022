// Написать программу вычесления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
Console.Clear();
Console.WriteLine("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат выполнения: {Sum(m, n)}");
int Sum(int from, int to)
{
    if (from == 0) return to + 1;
    else
        if ((from != 0) && (to == 0)) return Sum(from - 1, 1);
    else
    return Sum(from - 1, Sum(from, to - 1));
}


