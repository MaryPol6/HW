using static System.Console;
Clear();
Write("Введите число - ");
int x = int.Parse(ReadLine());
int y = 2;
if(x>1) {
    while (y<=x) {
        Write(y);
        Write(" ");
        y = y+2;
    }
}

else WriteLine("Число меньше рабочего диапазона");
