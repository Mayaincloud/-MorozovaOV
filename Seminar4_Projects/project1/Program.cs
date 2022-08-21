﻿/*
Напишите программу, которая 
принимает на вход число (А) и выдаёт сумму чисел 
от 1 до А.
7 -> 28
4 -> 10
8 -> 36
задаем число А, создаем метод возвращаемого типа, который будет выдавать 
сумму чисел от 1 до А
задаем счетчик, который будет увеличиваться каждый проход цикла 
добавляем переменную, которая будет содержать в себе сумму 
*/

Console.Clear();
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

int GetSumNums(int number)
{
    int sum = 0;
    int i = 1;
    while(i <= number)
    {
        sum +=i;
        Console.Write($"{sum} ");
        
        i++;
                     
          }
    return sum;

}

Console.Write($"Сумма чисел от 1 до {num} = {GetSumNums(num)}");
