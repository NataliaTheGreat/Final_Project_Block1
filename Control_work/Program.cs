//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которрых меньше либо равна 3 символами.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритмы

int Prompt(string message)
{
    System.Console.Write(message); //вывести сообщение
    string value = Console.ReadLine();//считывает с консоли строку
    int result = Convert.ToInt32(value); //преобразует строку в целое число
    return result; //возвращает результат
}


//Ввести массив
string[] InputArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

//Вывести массив
void PrintArray(string[] array)
{
    Console.WriteLine($"Заданный массив ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
Console.WriteLine();
Console.WriteLine();

}

//Вывести массив  со строками <3 символов
void PrintArrayThreeSymbols(string[] array)
{
    Console.WriteLine($"Массив из строк, длина которых меньше либо равна 3 символам");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write($"{array[i]} ");
    }
}

int lenght = Prompt("Введите поличество элементов массива ");
string[] array;
array = InputArray(lenght);
PrintArray(array);
PrintArrayThreeSymbols(array);

