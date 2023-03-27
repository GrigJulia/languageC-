//                   Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] ArrayFree(int size, int minValue, int maxVaiue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxVaiue);
//     }
//     return newArray;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// void evenCount(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         count += 1;//counnt = counnt + 1;
//     }
// Console.WriteLine($"Количество чётеных чисел = {count}");
// }

// Console.WriteLine ("input aaray size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value array ellement");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("input maximal value of array element:");
// int maxVaiue = Convert.ToInt32(Console.ReadLine());

// int[] TestArray = ArrayFree(size, minValue, maxVaiue);
// printArray(TestArray);

// evenCount(TestArray);

//                    Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] Massiv(int size, int min, int max)
// {
//     int[] myArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(min, max);
//     }
//     return myArray;
// }

// void printArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }


// void negativSum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1)
//         sum += array[i];
//     }
//     Console.WriteLine($" сумма нечёьных эллементов массива ={sum}");
// }

// Console.WriteLine ("Введите размер массива size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите минимальное число массива");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("введите максимальное число массива");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] TestArray = Massiv(size, min, max);
// printArray(TestArray);

// negativSum(TestArray);


//                     Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] Massiv(int size, int minPer, int maxPer)
// {
//     double[] myArray = new double[size];
//     for (int i = 0; i < size; i++)
//     {
//         myArray[i] = new Random().Next(minPer, maxPer);
//     }
//     return myArray;
// }

// void printArray(double[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i]+ " ");
//     }
//     Console.WriteLine();
// }

// double FindMax(double[] array)
// {
//     double max = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > max)
//         {
//             max = array[i];
//         }
//     }
// return max;
// }

// double FindMin(double[] array)
// {
//     double min = array[0];

//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//     }
// return min;
// }

// void DifferenceMaxMin(double min, double max)
// {
//     double result = max - min;
// Console.WriteLine($"раздница между max ={max} и min = {min} =>{result}");
// }

// Console.WriteLine ("Введите размер массива size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("введите минимальное число массива");
// int minPer = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("введите максимальное число массива");
// int maxPer = Convert.ToInt32(Console.ReadLine());

// double[] TestArray = Massiv(size, minPer, maxPer);
// printArray(TestArray);

// double max = FindMin(TestArray);
// double min = FindMax(TestArray);

// DifferenceMaxMin(max, min);