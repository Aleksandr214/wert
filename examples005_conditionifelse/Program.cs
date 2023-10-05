Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine ();

if(username.ToLower() == "МАША")
{
    Console.WriteLine("Ура, это уже маша");
}
else
{
    Console.Write("привет,");
    Console.WriteLine(username);
}