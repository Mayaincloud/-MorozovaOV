/*
11. Напишите программу, которая выводит случайное трехзначное число
и удаляет вторую цифру этого числа
456 -> 46
782 -> 72
918 -> 98
*/

int randomNumber = new Random().Next(100, 1000);
int firstNumber = randomNumber / 100;
int thirdNumber = randomNumber % 10;
int number = firstNumber * 10 + thirdNumber;

Console.WriteLine($"Сгенерированное число {randomNumber}. Получившееся число {number}.");
