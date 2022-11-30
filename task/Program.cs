// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string InputMessage(string message)
{
    Console.Write(message);
    return Console.ReadLine();
}

string[] rowsOfElements()
{
    int size = Convert.ToInt32(InputMessage("Введите количество строк: "));
    string[] elements = new string[size];

    for (int i = 0; i < size; i++)
    {
        elements[i] = InputMessage($"Введите {i+1}-ю строку: ");
    }

    return elements;
}

int FindSizeOfNewArray(string[] array, int limitLength) 
{
    int sizeNewArray = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < limitLength)
        {
            sizeNewArray++;
        }
    }
    return sizeNewArray;
}

string[] resultNewArrayOfStrings(string[] array, int size, int limitLength)
{
    string[] newArray = new string[size];

    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length < limitLength)
        {
            newArray[i] = array[j];
            i++;
        }
            
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i ++)
    { 
        if(i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        if (i == array.Length - 1)
        {
            Console.Write($"{array[i]}]");
        }
    }
}

string[] array = rowsOfElements();
int maxLength = 4; 
int sizeOfNewarray = FindSizeOfNewArray(array, maxLength); 
if (sizeOfNewarray == 0)
{
    Console.WriteLine();
    Console.WriteLine("Все введённые строки содержат более 3 (трёх) символов.");
}
if (sizeOfNewarray != 0)
{
    string[] newArray = resultNewArrayOfStrings(array, sizeOfNewarray, maxLength); 
    Console.WriteLine();
    PrintArray(newArray);
}