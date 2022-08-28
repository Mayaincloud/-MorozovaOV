/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Write($"Какое количество чисел вы хотите ввести?: ");
int m = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[m];

 int [] InputArray(int m)
{
   
    for(int i = 0; i < m; i++)
    {
        Console.Write($"Введите число от -100 до 100: ");
        userArray[i] = Convert.ToInt32(Console.ReadLine());
        
       
    }
        return userArray;
}
InputArray(m);



    int j = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if (userArray[i] > 0) j += 1;
    }
    

Console.WriteLine($"Введено чисел больше 0: {j} ");