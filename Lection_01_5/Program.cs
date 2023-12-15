Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "рыжий")
{
    Console.WriteLine("Ура, это Рыжий");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}