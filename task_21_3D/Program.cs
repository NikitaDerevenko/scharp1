/* Внутри класса Answer напишите метод DistanceBetweenPoints, который принимает на вход координаты 
двух точек pointA и pointB в виде массива целых чисел, и возвращает расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7) -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */


System.Console.WriteLine("Введите номер четверти: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");


int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");
int z2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер четверти: ");

double d = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)),2);
System.Console.WriteLine(d);