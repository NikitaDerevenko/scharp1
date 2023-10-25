/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */




{
    Console.WriteLine("Введите цифру, обозначающую день недели (1-7):");
    int day = Convert.ToInt32(Console.ReadLine());

    bool isWeekend = CheckIfWeekend(day);

    if (isWeekend)
    {
        Console.WriteLine("День является выходным");
    }
    else
    {
        Console.WriteLine("День не является выходным");
    }
}

static bool CheckIfWeekend(int day)
{
    
    return (day == 6 || day == 7);
}
