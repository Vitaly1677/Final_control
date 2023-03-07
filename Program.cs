/// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"]-> []

int stringLenghtFilter = 3;
string[] arrayInit = new string[] { "hello", "2", "world", ":-)" };

PrintArray(arrayInit);
Console.Write(" -> ");

string[] arrayFiltered = CreateArrayFiltred(stringLenghtFilter, arrayInit);
PrintArray(arrayFiltered);
Console.WriteLine("");

string[] CreateArrayFiltred(int strLenghtFiltr, string[] arrInit)
{
    int lenghtArrayNew = 0;
    string[] arrTemp = new string[arrInit.Length];
    for (int i = 0; i < arrInit.Length; i++)
    {
        if (arrInit[i].Length <= stringLenghtFilter)
        {
            arrTemp[lenghtArrayNew] = arrInit[i];
            lenghtArrayNew++;
        }
    }
    string[] arrayNew = new string[lenghtArrayNew];
    for (int i = 0; i < lenghtArrayNew; i++)
    {
        arrayNew[i] = arrTemp[i];
    }
    return arrayNew;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i]);
        if (i < arr.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}