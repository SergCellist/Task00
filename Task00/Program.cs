﻿// Напишите программу, которая
// 1. на вход принимает число
// 2. выдаёт его квадрат (число умножить само на себя)
// 3. вывод результата
// Например:
// 4 => 16
// -3 => 9
// -7 => 49

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.WriteLine(number + " => " + square);
Console.WriteLine($"{number} -> {square}");
