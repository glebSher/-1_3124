﻿// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли первое число кратным второму. Если число 1 не кратно числу 2, 
// то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

int number1, number2;
Console.WriteLine("Введите два числа и программа проверит, является первое число кратным второму");
number1 = Convert.ToInt32 (Console.ReadLine());
number2 = Convert.ToInt32 (Console.ReadLine());

int mod = number1 % number2;

if (mod == 0)
{
    Console.WriteLine ($"Число {number1} кратно числу {number2}");
}
else 
{
    Console.WriteLine ($"Число {number1} не кратно числу {number2}. Остаток от деления {mod}");
}

