﻿// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int digit_3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((digit_3 /10) % 10);