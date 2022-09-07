Console.Clear();
Console.WriteLine("Введите день недели цифрой от 1 до 7: ");
int user_num = int.Parse(Console.ReadLine());

if (user_num == 6 || user_num == 7)
{
    Console.WriteLine("Сегодня выходной.");
}
else if (user_num < 1 || user_num > 7)
{
    Console.WriteLine("Введена неправильная цифра.");
}
else Console.WriteLine("Будний день.");
