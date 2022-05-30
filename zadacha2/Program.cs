Console.Write("Введите число: ");
string writeNumberA = Console.ReadLine();
int numberA = Convert.ToInt32(writeNumberA);

Console.Write("Введите число: ");
string writeNumberB = Console.ReadLine();
int numberB = Convert.ToInt32(writeNumberB);

Console.Write("Введите число: ");
string writeNumberC = Console.ReadLine();
int numberC = Convert.ToInt32(writeNumberC); 

int max = numberA;

if (numberA > max) max = numberA;
if (numberB > max) max = numberB;
if (numberC > max) max = numberC;

Console.Write("max = ");
Console.WriteLine(max);