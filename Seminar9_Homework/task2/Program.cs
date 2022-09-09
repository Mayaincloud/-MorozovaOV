/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму чётных чисел натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 56
M = 4; N = 8. -> 18*/

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}

int sumItems = SumItems(m, n, temp = 0);
Console.Write($"Сумма четных чисел в промежутке от {m} до {n}: {sumItems}");

int SumItems(int m, int n, int sum)
{
    if (m % 2 != 0)
    {
        m++;
    }
    for (; m <= n;)
    {
        sum = sum + m;
        m = m + 2;
    }
    return sum;
}



