﻿/* Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/
System.Console.Write("Введите 3-х значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine("Вторая цифра этого числа -> "+stringNumber[1]);

