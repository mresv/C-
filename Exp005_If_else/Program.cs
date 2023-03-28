Console.Write("Введите имя пользователя: ");

string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.Write("Ура! Это же Маша!");
}
else
{
Console.Write("Приветствую тебя, ");
Console.Write(username);
}