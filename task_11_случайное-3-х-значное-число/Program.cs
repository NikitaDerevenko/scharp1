/* Напишите программу, которая выводит случайное 3-х значное число и удаляет вторую цифру этого числа.
456 -> 46
421 -> 41*/

int number = new Random(). Next(100,999);
System.Console.WriteLine(number);

int first = number / 100;
int last = number % 10;
int result = first * 10 + last;

System.Console.WriteLine(result);



