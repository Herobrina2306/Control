//Программа выводит эленеты массива в котором три или меньше символа.

string[] array = {"Привет.", "Как", "дела", "?", "Вы", "разрешили", "ввести", "массив", "самой.", ";)"};

string[] newArray = Selection(array);

PrintArray(array);
Console.Write(" -> ");
PrintArray(newArray);

string[] Selection(string[] arr)
{
    int size = arr.Length;
    string[] arrayFin = new string[size];
    int len = 3;
    int NumberOfCharacters = 0;
    int counterArrayFin = 0;
    for(int i = 0; i< arr.Length; i++)
    {
        NumberOfCharacters = arr[i].Length;
        if(NumberOfCharacters <= len)
        {
            arrayFin[counterArrayFin] = arr[i];
            counterArrayFin++;
        }
        
    }
    


return arrayFin;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($"{arr[arr.Length-1]}]");
}