/* Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */


//static void Master(string[] args)

int[] array = CreateArray();
PrintArray(array);


static int[] CreateArray()
{
    int[] array = new int[8];
    Console.WriteLine("Введите 8 элементов массива:");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Элемент {0}: ", i + 1);
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

static void PrintArray(int[] array)
{
    Console.WriteLine("Массив:");

    for (int i = 0; i < array.Length; i++)
    {
         Console.Write("Элемент {0}-{1},  ", i + 1, array[i]);
    }
}
