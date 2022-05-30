Console.WriteLine();
Console.Write("Введите число: ");
string writeNumberA = Console.ReadLine();
int numberA = Convert.ToInt32(writeNumberA);

Console.Write("Введите число: ");
string writeNumberB = Console.ReadLine();
int numberB = Convert.ToInt32(writeNumberB);

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;

Console.Write("max = ");
Console.WriteLine(max);