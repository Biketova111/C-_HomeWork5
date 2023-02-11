/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6]4 -> 0 */

using System.Diagnostics.CodeAnalysis;

int GetNumber (string message)
{
    int result = 0;
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ошибка ввода, вы ввели не число. Повторите ввод:");
        }
    }
    return result;
}

int [] GenerateArray(int Lenght, int minValue, int maxValue)
{
    int [] array = new int [Lenght];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]}, "); 
    }
    Console.WriteLine();
}

int GetSum (int [] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum += arr[i];
        }
    }
return sum;
}

int lengthArray = GetNumber("Введите количество элементов массива: ");
int min = GetNumber("Начальное значение для диапазона случайных чисел: ");
int max = GetNumber("Конечное значение для диапазона случайных чисел: ");
int [] array = GenerateArray(lengthArray, min, max);
PrintArray (array);
int sum = GetSum (array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {sum}");
