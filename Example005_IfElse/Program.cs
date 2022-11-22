Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "оксана")
{
    Console.WriteLine("Привет,это же ОКСАНА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}