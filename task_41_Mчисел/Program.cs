// ДЗ
//41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2-1, -7, 567, 89, 223-> 3

// static void Main(string[] args)
{
    Console.WriteLine("Введите количество чисел:");
    int m = Convert.ToInt32(Console.ReadLine()); // Вводим количество чисел

    int count = 0; // Переменная для подсчета количества положительных чисел

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Введите число {i + 1}:");
        int number = Convert.ToInt32(Console.ReadLine()); // Вводим число

        if (number > 0)
        {
            count++; // Если число положительное, увеличиваем счетчик
        }
    }

    Console.WriteLine($"Количество положительных чисел: {count}");
}

