using static System.Console;
Clear();
Write("Введите первое число - ");
int a = int.Parse(ReadLine());
Write("Введите второе число - ");
int b = int.Parse(ReadLine());
Write("Введите третье число - ");
int c = int.Parse(ReadLine());

if(a>b&&a>c){
    WriteLine($"Максимальное число {a}");
}
if(b>a&&b>c){
    WriteLine($"Максимальное число {b}");
}

else WriteLine($"Максимальное число {c}");
