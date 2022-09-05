Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Наименьшее число: " + num2 + "." + " Наибольшее число: " + num1);
}