// // Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// // N = 5 -> "5, 4, 3, 2, 1"
// // N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите положительное число N больше нуля: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0 || n == 0) Console.WriteLine($"Просили же!!!!!!!!!!!!! Перечитай, что нужно ввести!!!!!!");

void Order(int n)
{
    if (n > 0)
    {
        Console.Write($"{n} ");
        Order(n - 1);
    }
}

Order(n);






// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalSum(int m, int n)
{
    int start = m;
    int end = n;
    
    if (m > n) 
    {
        start = n;
        end =  m;
    }
    return (end + start)*(end - start + 1)/2; // ф-ла суммы арифм прогрессии
}

Console.Write(NaturalSum(m,n));
