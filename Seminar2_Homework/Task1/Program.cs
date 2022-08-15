/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на 
выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
Console.Write("Введите трехзначное число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int userNumberLength = userNumber.ToString().Length;
if (userNumberLength != 3 )
{
    Console.WriteLine("Вы ввели не трехзначное число.");
    //Console.WriteLine("Введите трехзначное число. ");
}
else
{
    userNumber = userNumber % 100;
    userNumber = userNumber / 10;
    Console.WriteLine($"Вторая цифра числа: {userNumber}");
}