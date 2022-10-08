// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// // m = 3, n = 4.
// // 0,5 7 -2 -0,2
// // 1 -3,3 8 -9,9
// // 8 7,8 -7,1 9


void FillArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Random random = new Random();
            matr[m, n] = random.NextDouble();
        }
    }
}

void PrintArray(double[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{Math.Round(matr[m, n] * 100, 2)} ");
        }
        Console.WriteLine();
    }
}


double[,] matrix = new double[3, 4];


FillArray(matrix);
PrintArray(matrix);








// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет



int[,] matrix = new int[3, 4];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 100);
        Console.Write($"{matrix[i, j]} ");

    }
    Console.WriteLine();
}


Console.WriteLine();

Console.WriteLine("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < matrix.GetLength(0))
{
    if (b < matrix.GetLength(1))

    {
        Console.WriteLine(matrix[a, b]);
    }
    else
    {
        Console.WriteLine("Что-то ты не то ввёл, дружок");
    }
}

















// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.






int[,] matrix = new int[3, 4];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 100);
        Console.Write($"{matrix[i, j]} ");

    }
    Console.WriteLine();
}
Console.WriteLine();

for (int n = 0; n < matrix.GetLength(1); n++)
{
    double sum = 0;
    for (int m = 0; m < matrix.GetLength(0); m++)
    {

        sum = sum + matrix[m, n];

    }

    Console.Write(Math.Round(sum / matrix.GetLength(0), 1));
    Console.Write(" ");

}
