// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Enter the max number: ");
int user_num = Convert.ToInt32(Console.ReadLine());

void cubed_nums(int num)
{
    for (int i = 1; i <= num; i++)
    {
        double cubed = Math.Pow(i, 3);
        Console.WriteLine(cubed);
    }
}

cubed_nums(user_num);