using static System.Console;
Clear();
WriteLine("Введите число");
int x = int.Parse(ReadLine());
int y = x%2;
if(y==0) WriteLine($"Число {x} четное");
else WriteLine($"Число {x} нечетное");

