/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

System.Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());

int Summa(int a)
{
    int result = 0;
    for (int i = a; i > 0; i /= 10)
    {
        result = result % 10 + i;
    }
    return result;
}
int userResult = Summa(userNumber);
System.Console.WriteLine($"{userNumber} -> {userResult}");