// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N.
// Math.sqrt - квадратный корень!
// Math.pow - возведение в степень
System.Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= n; i++)
    System.Console.Write(Math.Pow(i, 2)+ " ");
