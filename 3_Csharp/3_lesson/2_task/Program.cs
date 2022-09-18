// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Double x1, x2, y1, y2, z1, z2, distance;
Console.Write("Enter coordinate x1: ");
x1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate x2: ");
x2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y1: ");
y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate y2: ");
y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate z1: ");
z1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter coordinate z2: ");
z2 = Convert.ToDouble(Console.ReadLine());

distance = Math.Sqrt(Math.Pow(x2-x1,2) + Math.Pow(y2-y1,2) + Math.Pow(z2-z1,2));
Console.WriteLine($"The distance between 3 points is {Math.Round(distance, 2)}");
