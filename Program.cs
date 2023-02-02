// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

// Console.Write("Введите количество чисел: ");
// int number = int.Parse(Console.ReadLine()!);
// int count = 0;
// for (int i = 0; i < number; i++)
// {
//     Console.Write($"Введите число {i + 1}: ");
//     int x = int.Parse(Console.ReadLine()!);
//     if (x > 0)
//         count++;
// }
// Console.WriteLine($"Количество положительных чисел: {count}");


// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Значение b1");
int b1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Значение k1");
int k1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Значение b2");
int b2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Значение k1");
int k2 = int.Parse(Console.ReadLine()!);
double x = -0.5;
double y = k1 * x + b1;
double y1 = k2 * x + b2;
Console.WriteLine($"Ответ {y}; {y1}");