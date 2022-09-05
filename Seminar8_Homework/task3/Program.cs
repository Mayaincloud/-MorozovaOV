/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = GetArray(rows, columns, 0, 4);
Console.Write("Первая матрица: ");
Console.WriteLine();
PrintArray(matrix1);
Console.WriteLine();
int[,] matrix2 = GetArray(rows, columns, 0, 4);
Console.Write("Вторая матрица: ");
Console.WriteLine();
PrintArray(matrix2);
int[,] resultMatrix = ProductMatrix(matrix1, matrix2);
Console.WriteLine("Результирующая матрица будет равна:");
PrintArray(resultMatrix);

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

int[,] ProductMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int [matrix1.GetLength(0), matrix2.GetLength(1)];
    for(int i = 0; i < result.GetLength(0); i++)
    {
        for(int j = 0; j < result.GetLength(1); j++)
        {
            for(int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i,j] = result[i,j] + matrix1[i,k] * matrix2[k,j];
            }
        }
    }
    return result;
}