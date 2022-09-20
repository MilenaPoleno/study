// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.WriteLine("Введите трёхзначное число ");
int x = Convert.ToInt32(Console.ReadLine());

int a = x%10;
int b = (x - a)/10;
int c = b%10;

Console.WriteLine(c);



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int ost = 0;
int r = 10;

int col = 0;

while (ost < a)
{
   ost = a % r;
    r = r * 10;
    col++;
}
if (col < 3)
{
    Console.WriteLine("нема третьей цифры");
}
else
{
    int result = (a / (int)Math.Pow(10, col - 3)) % 10;
    Console.WriteLine(result);
}






//Доп решение, если нужно 3ю цифру с конца

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
int nth = 3;


int result = (a / (int)Math.Pow(10,nth-1)) % 10;
if (a > 99)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нема");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


// array[0] = "Понедельник";
// array[1] = "Вторник";
// array[2] = "Среда";
// array[3] = "Четверг";
// array[4] = "Пятница";
// array[5] = "Суббота";
// array[6] = "Воскресенье";

Console.WriteLine("Введите цифру от 1 до 7  ");

int x = Convert.ToInt32(Console.ReadLine());

int[] array = { 1, 2, 3, 4, 5, 6, 7 };

int i = 0;
int n = array.Length;



while (i < n)
{
    if (array[6] == x | array[5] == x)
    {
        Console.WriteLine(x + " Да!!! выходной!!! Кайфуй, братва!!!");
        break;
    }

    if (array[4] == x | array[3] == x | array[2] == x | array[1] == x | array[0] == x)
    {
        Console.WriteLine(x + " Нет, это рабочий день! Иди плоти нологе!!!");
        break;
    }
    else
    {
        Console.WriteLine(x + " ТЫ втираешь мне какую-то дичь!!!");
        break;
    }

}

