//Задайте значения M и N . Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// Не использовать результирующую переменную
// Решать через рекурсию!!!
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
Console.WriteLine("введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Результат выполнения: {Sum(m, n)}");
int Sum(int from, int to)
{
    if ( from > to) return Sum(to, from);
    if (from == to) return from ;
    return from + Sum(from + 1, to);
}
