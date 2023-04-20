Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "marat")
{

    Console.WriteLine("Ура это хозяин");

}
else
{
    Console.WriteLine("Привет");
    Console.WriteLine(username);

}