// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();

Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if(x>y)
{

    Console.WriteLine("Первое число больше второго, это  " + x);
}
else
{

    Console.WriteLine("Второе число победило! И это число " + y);
}








// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


Console.Clear();
Console.WriteLine("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int z = Convert.ToInt32(Console.ReadLine());

int max = x;

if (x > max) max = x;
if (y > max) max = y;
if (z > max) max = z;

Console.Write("Самое большое число - это " + max);










// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();

Console.WriteLine("Введите число: ");

int x = Convert.ToInt32(Console.ReadLine());

int result = x % 2;

if (result == 0)
{

    Console.Write("Ура!!! Число четное!!!");
}

else
{

    Console.Write("Превосходно!!! Число нечетное!!!");
}









// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int N =Convert.ToInt32(Console.ReadLine());
int i = 0;

while(i < N + 1)
{

    Console.Write(i + ", ");
    i = i + 2;
}

