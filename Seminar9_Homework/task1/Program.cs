/*Задача 64: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N 
от большего к меньшему.
M = 1; N = 5. -> ""5, 4, 3, 2, 1""
M = 4; N = 8. -> ""8, 7, 6, 5, 4""*/

Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N, которое должно быть больше М: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintNumber (n,m);

void PrintNumber(int n, int m)
{
  if (m > n) return;
  PrintNumber(n, m + 1);
  Console.Write(m + " ");
}