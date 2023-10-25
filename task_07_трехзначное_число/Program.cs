// Напишите программу, которая принимает трехзначное число, а на выходе показывает последнюю цифру этого числа

Console.Write("Введи трёхзначное число: ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(ThreeDigitNumber);
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);