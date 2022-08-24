/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество 
чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/

int [] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{res[i]} ");
    }
    return res;
}

int [] array = GetArray(12, 100, 999);
Console.WriteLine();

int amt = 0;

for(int i =0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        amt++;
    }
}

Console.WriteLine($"В массиве {amt} четных чисел");