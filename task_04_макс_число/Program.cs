// Напишите метод FindMax, который принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.WriteLine("Введите 3 числа: ");
System.Console.WriteLine("Введите 1-ое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-ее число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

{
     int max = num1;
     
        if (num2 > num1)
        {
         max = num2;
        }
        if (num3 > max)
        {  
          max = num3;
        }
System.Console.WriteLine("Максимальное число: " + max);
return max;
}
