﻿// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.


void WriteTableSquare(int number)
{
    int i =1;
    while (i <= number)
    {
        Console.WriteLine($"{i,3}-> {i * i,5}");
        i++;
    }
}
Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
// int i = 0;

// while (i <= n)
// {
//     Console.WriteLine($"{i,3}-> {i * i,5}");
//     i++;
// }
WriteTableSquare(n);

