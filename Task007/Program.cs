﻿//7. Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает последнюю цифру
//этого числа.
//456 -> 6
//782 -> 2
//918 -> 8



Console.WriteLine("Введите трёхзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) number *= -1;                 // для работы с отрицательными числами
if (number >= 100 && number <= 999)
{
    int lastDigit = number % 10; //что б получить третью цифру,надо получить остаток от деления на 10
    Console.WriteLine($"Последняя цифра чила -> {lastDigit}");
}
else {
 Console.WriteLine("Некорректный ввод");   
}