/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


Console.Write("Введите цифру от 1 до 7, обозначающую день недели: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
if (userNumber == 1)
{
   Console.WriteLine("Понедельник - рабочий день"); 
}

else if (userNumber == 2)
{
   Console.WriteLine("Вторник - рабочий день"); 
}

else if (userNumber == 3)
{
   Console.WriteLine("Среда - рабочий день"); 
}

else if (userNumber == 4)
{
   Console.WriteLine("Четверг - рабочий день"); 
}

else if (userNumber == 5)
{
   Console.WriteLine("Пятница - рабочий день"); 
}

else if (userNumber == 6)
{
   Console.WriteLine("Суббота - выходной день"); 
}

else if (userNumber == 7)
{
   Console.WriteLine("Воскресенье - выходной день"); 
}

else
{
   Console.WriteLine("Такой день недели не существует"); 
}