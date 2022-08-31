/*Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/

Console.WriteLine("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(rows, columns);
PrintArray(array);

double[,] GetArray(int rows, int columns)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().NextDouble();
            result[i, j] = Math.Round(result[i, j], 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
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


