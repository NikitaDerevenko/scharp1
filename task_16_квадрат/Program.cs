/* Напишите программу, которая принимает на вход два числа и проверяет является ли одно число квадратом второго*/

Console.WriteLine ("Напишите 2 числа ");
Console.WriteLine ("Введите 1-ое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
 
 if (num1 == num2 * num2 || num2 == num1 * num1)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}