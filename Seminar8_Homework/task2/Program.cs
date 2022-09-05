/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с
наименьшей суммой элементов: 1 строка*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();
int[] sumRow = SumRow(array);
Console.WriteLine($"Номер строки с наименьшей суммой элементов равен {MinSumRowIndex(sumRow) + 1}");


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max);
        }
    }
    return result;
}

void PrintArray(int[,] array)
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

int[] SumRow(int[,] array)

{
    int[] result = new int [array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           result[i] = result[i] + array[i,j];
        }
    }
    return result;
}

int MinSumRowIndex(int[] array)
{
    int result = 0;
    int minIndex = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(array[i] < minIndex)
        {
            result = i;
            minIndex = array[i];
        }
    }
    return result;
}