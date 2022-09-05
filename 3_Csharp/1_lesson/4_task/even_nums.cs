Console.Write("Введите число максимальное число: ");
int max_num = Convert.ToInt32(Console.ReadLine());
int num = 1;
while (num <= max_num)
{
    if (num%2 == 0){
        Console.WriteLine(num);
        num++;
    }
    else{
        num++;
    }
}