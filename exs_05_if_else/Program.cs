Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "марли")
{
    Console.WriteLine("Извольте кушать, Марли");
}
else
{
    Console.Write("Здравствуйте, ");
    Console.WriteLine(username);
}