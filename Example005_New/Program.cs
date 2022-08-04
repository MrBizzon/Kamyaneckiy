Console.Write("Введите имя ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")
{
    Console.WriteLine("Дура пришла");
}
else
{
    Console.Write("Привет, ");
    Console.Write(username);
}
