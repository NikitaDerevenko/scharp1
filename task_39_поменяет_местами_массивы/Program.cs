// Напишите программу, которая перевернет одномерный массив - первый массив будет последним и наоборот

int[] GetRnd(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,10);
    }
    return array;
}

int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i]);
        if (i < arr.Length - 1) System.Console.Write(", ");// [5, 7, 1, 4
    }
    System.Console.Write("]");
}

void Reverse(int [] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = array[i];
        array[i] = temp;
    }
}
int size = Prompt ("Задай размер массива: ");
int []userArray = GetRnd(size);
PrintArray(userArray);
System.Console.WriteLine();
Reverse(userArray);
PrintArray(userArray); 
