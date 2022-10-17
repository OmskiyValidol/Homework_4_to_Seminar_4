﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

class Programm
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество элементов массива: ");
        int elementsCount = int.Parse(Console.ReadLine()!);

        int[] myArray = new int[elementsCount];

        for (int i = 0; i < myArray.Length; i++)
        {
            Console.Write($"Введите элемент массива под индексом {i}: ");
            myArray[i] = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine(String.Join(", ", myArray));

    }
}