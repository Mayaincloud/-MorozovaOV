/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

//Нужно создать цикл, который будет умножать число А на себя В раз

Console.WriteLine("Введите первое число:");
int UserNumber1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int UserNumber2 = Convert.ToInt32(Console.ReadLine());

int UserNumberDegree = UserNumber1;

for(int i = 1; i < UserNumber2; i++)
{
    UserNumberDegree = UserNumberDegree * UserNumber1;
 
}

Console.WriteLine($"{UserNumber1} в степени {UserNumber2} равно {UserNumberDegree}");
