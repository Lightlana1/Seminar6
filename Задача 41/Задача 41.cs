void task41()
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
{
    Console.WriteLine("Введите 5 чисел");
    int size = 5;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Positive(numbers);
}

void FillArray(int[] numbers)
{
    int size = numbers.Length;
    for(int i = 0; i<size; i++)
    {
        Console.WriteLine("Введите {0}-е число", i + 1);
        numbers[i] = int.Parse(Console.ReadLine());
    }
}

void PrintArray(int[] numbers)
{
    int size = numbers.Length;
    Console.WriteLine ("Вы ввели числа");
    for (int i = 0; i < size; i++)
    {
        Console.Write(numbers[i] + ",");
    }
    Console.WriteLine();
}

void Positive(int[] numbers)
{
    int size = numbers.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (numbers[i] > 0)
        {
            count = count + 1;
        }
    } 
    Console.Write("Введено положительных чисел: " + count);
}

task41();