// Задача 19         Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Poliandrom(int number)
// {
//     int n = number % 10;
//     int i = number / 10 % 10;
//     int res = n * 10 + i;
//     if (number / 1000 == res)
//     Console.WriteLine("{number} -> да");
//     else
//     {
//     Console.WriteLine("{number} -> нет");
//     }
// }
// Console.WriteLine("введите пятизначное число:");
// int number = Convert.ToInt32(Console.ReadLine());
// Poliandrom(number);

// Задача 21         Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// double TreeD(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2)), 2);
// }

// Console.WriteLine("Input coordinate X of A point: ");
// double x1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of A point: ");
// double y1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of A point: ");
// double z1 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate X of B point: ");
// double x2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y of B point: ");
// double y2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z of B point: ");
// double z2 = Convert.ToDouble(Console.ReadLine());

// double distance = TreeD(x1, y1, x2, y2, z1, z2);
// Console.WriteLine($"Distance between A and B is {distance}");


// Задача 23          Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Power(double N)
// {
//     int i = 1;
//     while (i <= N)
//     {
//         Console.Write($"{N} -> {Math.Pow(i, 3)}");
//         i++;
//     }
// }
// Console.WriteLine("input the number N:");
// int N = Convert.ToInt32(Console.ReadLine());
// Power(N);
