﻿// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int SumNumbers(int num)
{
    int sum = 0;
    for (int i = 0; i <= num; i++)
    checked
    {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine());

int sumNumbers = SumNumbers(number);
if (number < 1)
{
    Console.WriteLine("Введено некоректное число");
    return;
}

Console.WriteLine($"Сумму чисел от 1 до {number} = {sumNumbers}");

