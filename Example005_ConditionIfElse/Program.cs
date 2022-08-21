Console.Write("Введите имя пользователя: ");
string? username = Console.ReadLine();

if(username?.ToLower() == "оля")
{
    Console.WriteLine("Ура! Это же Оля!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}