// Напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).
System.Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if ((a % 2) == 0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечетное");
}
