/*firstNumber: '5'
secondNumber: '6' Найти большее значение из двух чисел */

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
{
        
        if (number1 > number2)
        {
            Console.WriteLine($"{number1} больше, чем {number2}");
        }
        else if (number1 < number2)
        {
            Console.WriteLine($"{number1} меньше, чем {number2}");
        }
        else
        {
            Console.WriteLine($"{number1} и {number2} равны");
        }
    

}