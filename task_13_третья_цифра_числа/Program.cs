/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

/* Console.WriteLine("Введите число:");
    int number = Convert.ToInt32(Console.ReadLine());
    int thirdDigit = thirdDigit (number)
    
        for (int i = 0; i < length; i++)
        thirdDigit = (number / 100);
        
        if (thirdDigit == -1)
        {
            Console.WriteLine("В числе меньше трех цифр");
        }
        else
        {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
        } */

/* Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int thirdDigit = GetThirdDigit(number);

{
while (number > 999)
    {
    number = / 10;
    }
return number % 10;
}    
   // if (thirdDigit != -1)
    {
        Console.WriteLine($"Третья цифра числа: {thirdDigit}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }

static int GetThirdDigit(int number)
{
    if (number < 0)
    {
        number = -number;
    }
    if (number < 100)
    {
        return -1;
    }
int thirdDigit = (number / 1000) %10;
return thirdDigit;
}*/

/* return result;

int digitsCount = GetDigitsCount(number)
{
while (number > 999)
    {
    number /= 10;
    }
return number % 10;
}

bool ValidateNumber(int number)
{
     if (number < 100)
    {
        System.Console.WriteLine("Третьей цифры нет");
        return false;
    }
return true
}*/

/*if (digitsCount < 3)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int thirdDigit = GetNthDigit(number, 3);
    Console.WriteLine($"Третья цифра: {thirdDigit}");
}
static int GetDigitsCount(int number)
{
    int count = 0;
    while (number != 0)
    {
        number /= 10;
        count++;
    }
    return count;
}
*/

Console.Write("Введи число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2){
  Console.WriteLine("третья цифра -> " + anyNumberText[2]);
}
else {
  Console.WriteLine("-> третьей цифры нет");
}