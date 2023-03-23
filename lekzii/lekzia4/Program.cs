// string[,] table = new String[2, 5];//
// table[1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//     for (int coloumns = 0; coloumns < 5; coloumns++)
//     {
//         Console.WriteLine($"-{table[rows, coloumns]}-");
//     }
// }


// int[,] matrix = new int[3, 4];

// for (int i = 0; i < matrix.GetLength(0); i++)//matrix.GetLength(0) просто поставить цифру нельзя. . означает длинну массива
// {
//     for (int j = 0; j < matrix.GetLength(1); j++)//   цифра в скобках указывает в данном случае на цифру 4
//     {
//         Console.Write($"{matrix[i, j]} ");
//     }
// Console.WriteLine();
// }
// void PrintArray(int[,] matr)
// {

//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             Console.Write($"{matr[i, j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr)
// {
//   for (int i = 0; i < matr.GetLength(0); i++)
//   {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//         matr[i,j] = new Random().Next(1, 10);
//     }
//   }  
// }
// int[,] matrix = new int[3, 4];
// PrintArray(matrix);
// FillArray(matrix);
// Console.WriteLine();
// PrintArray(matrix);

//         Факториал
// double Factorial( int n)//исправили инт на дабл из-за переполнения.
// {
//     if(n == 1) return 1;
//     else return n * Factorial(n-1);
// }
// for (int i = 1; i < 40; i++)
// {
// Console.WriteLine($"{i}! = {Factorial(i)}");//Console.WriteLine(Factorial(3));//1*2*3=6 факт 3
// }

//   фибоначи

// double Fibonacci(int n)
// {
//     if(n == 1 || n == 2) return 1;
//     else return Fibonacci(n-1) + Fibonacci(n-2);
// }

// for (int i = 1; i < 40; i++)// 
// {
//     Console.WriteLine(Fibonacci(i));
// }