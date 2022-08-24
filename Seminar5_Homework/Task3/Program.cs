/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

double [] GetArray(int size, int minValue, int maxValue)
{
    double [] res = new double [size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble();
       
        Console.Write($"{res[i]} ");
    }
    return res;
}

double [] array = GetArray(5, 0, 100);
Console.WriteLine();

double max = array[0];
double min = array[0];

for(int i = 1; i < array.Length; i++)
{
    if(array[i] > max)
    {
        max = array[i];
    }
    
    else if(array[i] < min)
    {     
        min = array[i];
         
    }
}

Console.WriteLine($"Разница между максимальным  и минимальным элементами массива равна {max - min}");
