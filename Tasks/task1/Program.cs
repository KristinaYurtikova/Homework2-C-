﻿//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите целое трехзначное число");
int numberA = int.Parse (Console.ReadLine()); // пользовательский ввод

int digit2 = (numberA / 10) % 10;

Console.WriteLine($"Вторая цифра числа {numberA} - {digit2}");





