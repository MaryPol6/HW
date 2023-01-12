using static System.Console;
Clear();
WriteLine("Введите первое число");
int a = int.Parse(ReadLine());
WriteLine("Введите второе число");
int b = int.Parse(ReadLine());

if(a>b) WriteLine($"{a} - максимальное число");
else WriteLine($"{b} - максимальное число");