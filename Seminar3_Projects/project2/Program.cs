/*
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек 
в этой четверти (x и y).
*/

Console.WriteLine("Введите число от 1 до 4: ");
int userNamber = Convert.ToInt32(Console.ReadLine());

if (userNamber == 1)
{
    Console.WriteLine("Дипазон значений х (0 , +бесконечности), а y (0 , +бесконечности)");
} 

else if (userNamber == 2)
{
    Console.WriteLine("Дипазон значений х (0 , +бесконечности), а y (0 , -бесконечности)");
}

else if (userNamber == 3)
{
    Console.WriteLine("Дипазон значений х (0 , -бесконечности), а y (0 , -бесконечности)");
}

else if (userNamber == 4)
{
    Console.WriteLine("Дипазон значений х (0 , -бесконечности), а y (0 , +бесконечности)");
}

else
{
    Console.WriteLine("Такой четверти не существует");
}

/*
Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат 
точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти");
int chetvert = Convert.ToInt32(Console.ReadLine());
switch (chetvert)
{
    case 1:
        {
            Console.WriteLine("X+, Y+");
            break;
        }
    case 2:
        {
            Console.WriteLine("-X, Y+");
            break;
        }
    case 3:
        {
            Console.WriteLine("-X, -Y");
            break;
        }
    case 4:
        {
            Console.WriteLine("X+, -Y");
            break;
        }
    default:
        {
            Console.WriteLine("Таких значений нет");
            break;
        }
}
*/
