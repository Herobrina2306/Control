//Программа выводит эленеты массива в котором три или меньше символа.

string[] array = {"Привет.", "Как", "дела", "?", "Вы", "разрешили", "ввести", "массив", "самой.", ";)"};

PrintArray(array);

// string[] Selection (string[] arr)
// {



// }

void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}