// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
int x = Convert.ToInt32(Console.ReadLine());
int ost = 0;
int r = 10;

int col = 0;

while (ost < x)
{
    ost = x % r;
    r = r * 10;
    col++;
}

int a = x % 10;
int b = x / 10 % 10;
int c = x / 1000 % 10;
int d = x / 10000 % 10;

if (col == 5)
{
    if (a == d & b == c)
        Console.WriteLine("-> поздравляем, это палиндром!");
    else
    {
        Console.WriteLine("-> не повезло, другалёк");
    }
}
else
{
    Console.WriteLine("По-братски же просили пятизначное!!!");
}


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
//√ (x2-x1)^2)+ (y2-y1)^2+ (z2-z1)^2

Console.Clear();
Console.WriteLine("Введите точку А");
Console.WriteLine("введите координату 1: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату 2: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату 3: ");
int az = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку Б");
Console.WriteLine("введите координату 1: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату 2: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите координату 3: ");
int bz = Convert.ToInt32(Console.ReadLine());
double R = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.WriteLine("Расстояние между точками = " + R);







// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Write("Введите число N:");
int a = System.Convert.ToInt32(Console.ReadLine());

Console.Write(a + " -> ");

for(int x = 1; x <= a; x++ )
{
    int res = (int)Math.Pow(x, 3);
    Console.Write(res + ", ");
}
