/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */


using System;
using System.Text.Json.Serialization;
using Microsoft.Win32.SafeHandles;

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


int GetQuantityEvenNumber (int [] array)
{
    int quantity = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]%2 == 0)
        {
            quantity ++;
        }
    }
return quantity;
}

int lengthArray = GetNumber("Введите количество элементов массива: ");
int [] arr = GenerateArray(lengthArray, 100, 999);
PrintArray (arr);
int quantityEvenNumber = GetQuantityEvenNumber(arr);
Console.WriteLine($"Количество четных чисел в массиве, равно {quantityEvenNumber}");