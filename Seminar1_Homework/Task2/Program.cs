﻿/*
Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

if(userNumber%2 == 0)
{
   Console.WriteLine($"{userNumber} - четное число"); 
}
else
{
    Console.WriteLine($"{userNumber} - нечетное число"); 
} 
