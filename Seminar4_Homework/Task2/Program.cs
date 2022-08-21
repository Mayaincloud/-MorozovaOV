/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/


Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int num = userNumber;

while(num > 0)
{
    sum = sum + num % 10;
    num = num / 10;
    
}

Console.WriteLine($"Сумма всех цифр числа {userNumber} равна {sum}");