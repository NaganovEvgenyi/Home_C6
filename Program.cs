﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
 //1, -7, 567, 89, 223-> 4

 Console.Write("Введите количество чисел: ");
 int number = int.Parse(Console.ReadLine()!);
 int count = 0;
 for (int i = 0; i < number; i++)
 {
     Console.Write($"Введите число {i + 1}: ");
     int x = int.Parse(Console.ReadLine()!);
     if (x > 0)
         count++;
 }
 Console.WriteLine($"Количество положительных чисел: {count}");
