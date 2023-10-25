/* Напишите программу, которая будет принимать на вход два числа и выводить является ли второе число кратным первым
Если второе число не кратное первому, то программа вводит остаток деления */

System.Console.WriteLine("Введите 2 числа: ");
System.Console.WriteLine("1-ое: ");
int number1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("2-ое: ");
int number2 = Convert.ToInt32(Console.ReadLine());
{
    if (number1 == number2 * number2)
    {
        System.Console.WriteLine("Кратные: " + number1 / number2);
    }
    else
    {
        System.Console.WriteLine("Числа некратные, остаток от деления: " + number1 % number2);
    }
}

