System.Console.WriteLine("Введите число: ");
int user_num = int.Parse(Console.ReadLine());
if (user_num / 100 == 0)
{
    System.Console.WriteLine("Третьей цифры нет.");
}
else
{
    string user_num_txt = Convert.ToString(user_num);
    Console.WriteLine("Третья цифра в числе: " + user_num_txt[2]);
}