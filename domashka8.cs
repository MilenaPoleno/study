// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void PrintArray(int [,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.WriteLine();
        }
    }

int[,] matrix = new int[3, 4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for (int k = 0; k < matrix.GetLength(0); k++)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {

            {
                if(matrix[k,j]> matrix[k, j-1])
                {int change = matrix[k, j];
                matrix[k, j] = matrix[k, j-1];
                matrix[k, j-1] = change;}
            }

        }

    }

}

PrintArray(matrix);








// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



int[,] matrix = new int[3, 3];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int a = 0;
int[] res = new int[matrix.GetLength(0)];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }

    Console.WriteLine($"Сумма в строке № {i + 1} равна {sum}");
    res[a] = sum;
    a++;
}

for(int m = 0; m < res.Length; m++)
{
    Console.Write(res[m] + " ");
}
Console.WriteLine();
int min = res[0];
int index = 0;
for(int n = 0; n < res.Length; n++)
{
    if (min >= res[n])
    {
        min = res[n];
        index = n;        
    }
}
Console.Write($"Наименьшая сумма в строке {index + 1} ");







// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] matrix1 = new int[3, 3];

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = new Random().Next(0, 10);
        Console.Write($"{matrix1[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();


int[,] matrix2 = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int m = 0; m < matrix2.GetLength(0); m++)
{
    for (int n = 0; n < matrix2.GetLength(1); n++)
    {
        matrix2[m, n] = new Random().Next(0, 10);
        Console.Write($"{matrix2[m, n]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int[,] resultMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

for (int x = 0; x < matrix1.GetLength(0); x++)
{
    for (int y = 0; y < matrix1.GetLength(1); y++)
    {
        resultMatrix[x, y] = matrix1[x,y] * matrix2[x,y];
        Console.Write($"{resultMatrix[x, y]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();








// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Введите число высоты массива: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число ширины массива: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число глубины массива: ");
int z = Convert.ToInt32(Console.ReadLine());

int[, ,] massiv3D = new int[x,y,z];
string[] numbers =  new string[massiv3D.GetLength(0)*massiv3D.GetLength(1)*massiv3D.GetLength(2)];
int index = 0;

for(int i = 0; i < massiv3D.GetLength(0); i++)
{
    for(int j = 0; j < massiv3D.GetLength(1); j++)
    {
        for (int k = 0; k < massiv3D.GetLength(2); k++)
        {
            massiv3D[i,j,k] = new Random().Next(10, 100);
            while(numbers.Contains(Convert.ToString(massiv3D[i,j,k])))
            {
                massiv3D[i,j,k] = new Random().Next(10, 100);
            }
            numbers[index] = Convert.ToString(massiv3D[i,j,k]);
            index++;
        }
    }
}

void PrintArray(int [, ,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for(int k = 0; k < massiv3D.GetLength(0); k++)
                {Console.Write($"{array[i, j,k]}({i},{j},{k}) ");}
                Console.WriteLine();
            }

        }
    }
PrintArray(massiv3D);








// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
int numIndex = 0;


int[,] matrix = {{22,22,22,22,22,22},
                 {22,0,0,0,0,22},
                 {22,0,0,0,0,22},
                 {22,0,0,0,0,22},
                 {22,0,0,0,0,22},
                 {22,22,22,22,22,22}};

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (array[i, j] == 22) Console.Write($"  "); 
            else if (array[i, j] < 10) Console.Write($"0{array[i, j]} ");
            else
                Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

void FillArray(int row, int col)
{

    if (matrix[row, col] == 0)
    {
        matrix[row, col] = numbers[numIndex];
        numIndex++;
        if (matrix[row, col] == 11) FillArray(row - 1, col);
        FillArray(row, col + 1);
        FillArray(row + 1, col);
        FillArray(row, col - 1);
        FillArray(row - 1, col);

    }

}

FillArray(1, 1);
PrintArray(matrix);







