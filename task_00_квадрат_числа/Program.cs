/*
0. Напишите программу, которая на вход принимает число и выдает 
его квадрат (число умноженное на само себя)
*/

System.Console.WriteLine("Введите число: ");//cw - быстрый вызов этой команды
int userNumber = Convert.ToInt32(Console.ReadLine());

int result = userNumber * userNumber;

Console.WriteLine(result);
Console.WriteLine(userNumber * userNumber);
