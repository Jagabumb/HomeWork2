﻿// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456-> 5
// 782-> 8
// 918-> 1

Console.WriteLine("Введите трехзначное число ");

int number = Int32.Parse(Console.ReadLine());
int number1 = (number / 10) % 10;
Console.WriteLine(number1);

