// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] randomArr(int start, int end, int lenghtArr)
{
    int[] arr = new int[lenghtArr];
    for (int i = 0; i < lenghtArr; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
    return arr;
}

int[] array = randomArr(100, 1000, 10);


for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");    
}

int col = 0;
for(int i = 0; i < array.Length; i++)
{
if(array[i] % 2 == 0) {col += 1;}
}

Console.WriteLine();
Console.WriteLine(col);






// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] randomArr(int start, int end, int lenghtArr)
{
    int[] arr = new int[lenghtArr];
    for (int i = 0; i < lenghtArr; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
    return arr;
}

int[] array = randomArr(-10, 100, 10);
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");    
}

int col = 0;
for(int i = 1; i < array.Length; i = i+2)
{
if(i % 2 == 1) {col = col + array[i];}
}

Console.WriteLine();
Console.WriteLine(col);







// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] randomArr(int start, int end, int lenghtArr)
{
    int[] arr = new int[lenghtArr];
    for (int i = 0; i < lenghtArr; i++)
    {
        arr[i] = new Random().Next(start, end);
    }
    return arr;
}

int[] array = randomArr(1, 100, 10);
for(int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} ");    
}


int max = array[0];
int min = array[0];

for(int i = 1; i < array.Length; i++)
{
if (array[i] > max) {max = array[i];}
if (array[i] < min) {min = array[i];}
}
Console.WriteLine();
Console.WriteLine (max);
Console.WriteLine (min);
Console.WriteLine (max - min);
