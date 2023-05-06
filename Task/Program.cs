// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []



// Описание решения:

// Приглашение к вводу данных с проверкой корректного ввода символов.


Console.Write("Введите количество элементов массива:");
int m = int.Parse(Console.ReadLine()!);
string[] stringArray = new string[m];
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine()!;
    }

}

// Функция counting — вначале считает количество элементов
// массива с тремя и менее символами. Затем создает массив 
// нужной размерностью и вносит данные из введенного массива
// в результат функции.

string[] counting(string[] stringArray)
{
    int n = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            n++;
    }
    string[] rez = new string[n];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            rez[j] = stringArray[i];
            j++;
        }
    }
    return rez;
}

//  Процедура printA выводит на экран значение массива 
//  с квадратными скобками в начале и в конце разделяя элементы запятыми.
void printA(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"{stringArray[i]},");
    }
    Console.Write("]");
}
array(stringArray);
printA(counting(stringArray));
