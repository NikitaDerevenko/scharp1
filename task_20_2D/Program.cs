// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

System.Console.WriteLine("Введите номер четверти: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)),2);
System.Console.WriteLine(d);