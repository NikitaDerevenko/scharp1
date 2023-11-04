
/* Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/


int TakeEnteredNumber(string message)
{
    System.Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
/*
int userNumber = TakeEnteredNumber("Введите число: ");
int FibonacciNumbers(int a)
{
    string result = "";
    if(a = 0) result = "0";
    if(a = 1) result = "0 1";
    if(a > 1)
    for (int i = 0; i <= a; i++)
    {
        result = result + 1;
    }
    return result;
}

System.Console.WriteLine(FibonacciNumbers(userNumber));*/


static void Main(string[] args)
{
    int N = 7;
    FibonacciNumbers(N);
}
static void FibonacciNumbers(int number)
{
    int[] arr = new int[number];
    int firstElement = 0;
    int secondElement = 1;
    for (int i = 0; i < number; i++)
    {
        if (i < 2)
        {
            arr[i] = i;
        }
        else
        {

            arr[i] = arr[firstElement] + arr[secondElement];
            firstElement++;
            secondElement++;
        }

        System.Console.Write($"{arr[i]} ");


    }

}
