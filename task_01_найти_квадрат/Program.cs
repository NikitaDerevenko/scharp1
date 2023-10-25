Console.WriteLine ("Напишите 2 числа ");
Console.WriteLine ("Введите 1-ое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите 2-ое число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
 
 if (userNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}