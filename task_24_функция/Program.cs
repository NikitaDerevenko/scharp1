/* Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А. */


/*int userA = 4;

double Num(int a);
{
    double result = Math.Pow(a,2);
    return result;
}

void Num1(int a)
{
    double result = Math.Pow(a,2);
    System.Console.WriteLine(result);
}*/

// Первое решение
/*
System.Console.Write("Напишите число: ");

int A = Convert.ToInt32(Console.ReadLine());
int sum = 0;

for (int i = 1; i <= A; i++)
{
    sum = sum + i;
}
System.Console.WriteLine(sum);*/


//Второе решение
System.Console.Write("Напишите число: ");
int userA = Convert.ToInt32(Console.ReadLine());

int Number(int a)
{
    int sum = 0;

    for (int i = 1; i <= a; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int userresult = Number(userA);
System.Console.WriteLine(userresult);