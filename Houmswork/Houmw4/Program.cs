// Урок 4. Функции
//                Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// double Cikl(int a, int b)
// {
// double res = Math.Pow(a, b);
// return res;
// }
// Console.WriteLine("input A");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input B");
// int b = Convert.ToInt32(Console.ReadLine());
// Cikl(a,b);
// Console.WriteLine($"{a}, {b} -> {Cikl(a,b)}");

//                Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Summa(int num)
// {
//     int res = 0;
//     while (num >= 9)
//     {
        
//         res = res + (num % 10);
//         num = num /10;
//     }
//     res = res + num;
//     return res;
// }
// Console.WriteLine("input Number");
// int num = Convert.ToInt32(Console.ReadLine());
// Summa(num);
// Console.WriteLine($"{num} -> {Summa(num)}");

//               Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]