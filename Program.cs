// Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] array = new string[7] {"23ytb", "90", "5f", "8mm8", "vvv", "1", "-7"};
string[] arrayRes = new string [array.Length];
int count = 0;
for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayRes[count] = array[i];
        count++;
        }
    }
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}
PrintArray(arrayRes);