// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int user_num = 0;
while (user_num < 10000 || user_num > 99999)
{
    Console.WriteLine("Введите 5-значное число: ");
    int num = int.Parse(Console.ReadLine());
    user_num = num;
}
string user_string = Convert.ToString(user_num);
System.Console.WriteLine(user_string);
if (user_string[0] == user_string[4] && user_string[1] ==  user_string[3])
{
    System.Console.WriteLine("Это палиндром.");
}
else System.Console.WriteLine("Это не палиндром.");