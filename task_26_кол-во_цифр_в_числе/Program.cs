//Напишите программу, которая принимает на вход число и выдает кол-во цифр в числе.

System.Console.WriteLine("Напишите число: ");
int userNum = Convert.ToInt32(Console.ReadLine());

int Result(int number)
{
    int count = 0;
    for (int i = number; i > 0; i /= 10)
    {
        count = count + 1;
    }
    return count;
}
int userCount = Result(userNum);
System.Console.WriteLine(userCount);
/*int count = 0;
for (int i = number; i > 0; i /= 10)
{
    count = count + 1;
}
*/