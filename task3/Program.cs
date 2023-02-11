/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

using System.ComponentModel.DataAnnotations;

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


double [] GenerateArray(int Lenght, int minValue, int maxValue)
{
    double [] array = new double [Lenght];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue+1);
    }
return array;
}

void PrintArray (double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write($"{array[i]}, "); 
    }
    Console.WriteLine();
}

double GetDifferenceMinMax(double [] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]<min)
        {
            min = arr[i];
        }
    }
       for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]> max)
        {
            max = arr[i];
        }
    }
double result = max-min;
return result;
}

int lengthArray = GetNumber("Введите количество элементов массива: ");
int min = GetNumber("Начальное значение для диапазона случайных чисел: ");
int max = GetNumber("Конечное значение для диапазона случайных чисел: ");
double [] array = GenerateArray(lengthArray, min, max);
PrintArray (array);
double difference = GetDifferenceMinMax(array);
Console.WriteLine($"Разницу между максимальным и минимальным элементов массива равна {difference}");

