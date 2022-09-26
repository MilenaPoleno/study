// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// насколько я поняла важно НЕ использовать Math.Pow))

Console.Clear();
Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int i = 1;
int res = 1;
while(i<B+1)
{
res = res * A;
i++;
}

Console.WriteLine(res);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.WriteLine("Введите число : ");
int a =Convert.ToInt32(Console.ReadLine());

int res = 0;

while(a > 0)
{
    res = res + a % 10;
    a = a / 10;
}

Console.WriteLine(res);





// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//1e решение если это ввод пользрвателем

Console.WriteLine("Введите первое число");
int a1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int a2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int a3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите четвертое число");
int a4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите пятое число");
int a5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите шестое число");
int a6 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите седьмое число");
int a7 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите восьмое число");
int a8 = Convert.ToInt32(Console.ReadLine());

int [] array = new int [8] {a1, a2, a3, a4, a5, a6, a7, a8};

int i = 0;

while(i < array.Length)
{
Console.Write(array[i] + ", ");
i++;
}


//2е решение если это генерирует программа (воставила ограничение на двухзначные числа, чтобы не было огромных полотен :))

int [] array = new int [8];
int i = 0;
while (i < array.Length)
{
array [i] = new Random().Next(0, 99);
Console.Write(array[i] + " ");
i++;
}
