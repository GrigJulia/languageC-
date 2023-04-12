// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void NaturNumber(int n)
// {
//     if (n>=1)
//     {
//         Console.Write(n+" ");
//         NaturNumber(n-1);
//         
//     }
// }
// NaturNumber(8);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNumbers(int m, int n)
// {
//     if (n > m)
//     {
//         return SumNumbers(m, n-1) + n;
//     }
//     else return (n);//                непонятно почему так, но работает)
// }
// Console.WriteLine(SumNumbers(4, 8));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// int AcermanFunkc(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     if (n== 0)
//     {
//         return AcermanFunkc(m -1,1);
//     }
//     else return AcermanFunkc(m -1, AcermanFunkc(m, n-1));
    
// }
// Console.WriteLine(AcermanFunkc(2, 3));