// // Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");

int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), Convert.ToInt32);
int sum = 0;
int i = 0;

while(i < array.Length)
{
   if(array[i] > 0) sum = sum + 1;
    i++;
}

Console.WriteLine($"Числе больше нуля введено {sum}");











// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//k1*x + b1 = k2*x + b2
//k1*x - k2*x = b2 - b1
//x(k1-k2) = b2-b1
//x = (b2-b1)/(k1-k2)
//y = k1*x + b1

Console.WriteLine("Введите первую координату первого отрезка (b1): ");
double b1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите вторую координату первого отрезка (k1): ");
double k1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите первую координату второго отрезка (b2): ");
double b2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите вторую координату второго отрезка (k2): ");
double k2 = int.Parse(Console.ReadLine()!);

double x = (b2-b1)/(k1-k2);
double y = k1*x + b1;

Console.WriteLine($"Точка пересечения двух заданных прямых находится в координатах ({x};{y})");
