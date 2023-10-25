/* НАпишите программу, которая принимает на вход число и проверяет кратна ли оно одновременно 7 и 23. */

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 == 0 && number % 23 == 0)
{
    Console.WriteLine($"{number} = кратному одновременно на 7 и на 23");
}
else
{
    Console.WriteLine($"{number} + не кратному одновременно на 7 и на 23");
}

