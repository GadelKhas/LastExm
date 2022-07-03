/*Задача**: Написать программу, которая из имеющегося массива
строк формирует массив из строк, длина которых меньше либо равна
 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
 задать на старте выполнения алгоритма. При решении не рекомендуется
  пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []
*/

void FillArray(string[] name)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("ВВедите нужный текст: ");
    for (int i = 0; i < name.Length; i++)
    {
        Console.Write($"[{i}] ");
        name[i] = Console.ReadLine();
    }
}
void PrintArray(string[] Array3)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    System.Console.Write("[");
    for (int i = 0; i < Array3.Length; i++)
    {
        System.Console.Write(Array3[i]);
        if (i != Array3.Length - 1)
        {
            System.Console.Write(", ");
        }
    }
    Console.ForegroundColor = ConsoleColor.Red;
    System.Console.Write($"] ");
}
string[] FindSymbol(string[] ThreeSymbol)
{
    int count = 0;
    string Symbol = String.Empty;
    for (int i = 0; i < ThreeSymbol.Length; i++)
    {
        Symbol = ThreeSymbol[i];
        if (Symbol.Length <= 3)
        {
            count++;
        }
    }
    string[] array2 = new string[count];
    count = 0;
    for (int i = 0; i < ThreeSymbol.Length; i++)
    {
        Symbol = ThreeSymbol[i];
        if (Symbol.Length <= 3)
        {
            array2[count] = Symbol;
            count++;
        }
    }
    return array2;
}
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Задайте размер массива целыми числами: ");

int sizeArray = Convert.ToInt32(Console.ReadLine());

string[] array = new string[sizeArray];

FillArray(array);
string[] array2 = FindSymbol(array);

PrintArray(array);
System.Console.Write( "-> ");
PrintArray(array2);
