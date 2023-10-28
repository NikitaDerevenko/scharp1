/* Напишите программу, которая примает на вход число N 
и выдает произведение чисел от 1 до N.*/

int Rrompt(string massage)
{
    System.Console.WriteLine(massage);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double MultNumber (int varA)
{
    int result = 1;
    for (int i = 1; i <= varA; i++)
    {
        result = result * i;
    }
    return result;
}

int varA = Rrompt("Введите число: ");
double result = MultNumber(varA);
System.Console.WriteLine(result);
