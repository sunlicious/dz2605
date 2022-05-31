Console.Write("Введите число:   ");
string A = Console.ReadLine();

int endNum = Convert.ToInt32(A);
int num = 0;
Console.WriteLine($"Чётные числа из диапазона от 1 до {endNum}:");
while (num < endNum)
{
    num++;
    if (num % 2 == 0) Console.Write($"{num} ");
}
Console.WriteLine();