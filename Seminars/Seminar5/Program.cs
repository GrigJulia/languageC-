//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreatRandArray (int size, int minValue, int maxVaiue)//создаёт массив
// {
//     int[] newArray = new int[size];//нью выделяет память на массив.
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxVaiue+1);
//     }
//     return newArray;
// }

// void ShowArray (int[] array)//выводит массив в консоль
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void Findsum(int[] array)//          находим сумму полож и отр. элементов массива.
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//        if(array[i] > 0) sumPos += array[i];
//        else sumNeg += array[i]; 
//     }
//     Console.WriteLine ($"Sum of positive digits is -> {sumPos}, Sum of negative digits is -> {sumNeg} ");
// }

// Console.WriteLine ("input aaray size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value array ellement");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("input maximal value of array element:");
// int maxVaiue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandArray (size, minValue, maxVaiue);
// ShowArray(myArray);

// Findsum(myArray);

//                                Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] ChangeElementsOfArray(int[] array)//с этим методом используем два верхних, создающий и выдающий массив.
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.WriteLine ("input aaray size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value array ellement");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("input maximal value of array element:");
// int maxVaiue = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreatRandArray (size, minValue, maxVaiue);
// ShowArray(myArray);

// myArray = ChangeElementsOfArray(myArray);//перезаписали массив
// ShowArray(myArray);//вывели перезаписаный массив.

//             Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// bool FindNumInaArray (int[] array, int num)//используем здесь 2 метода. создание и выведение массива.
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] == num) return true;   
//     }
//     return false;
// }

// Console.WriteLine ("input aaray size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value array ellement");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("input maximal value of array element:");
// int maxVaiue = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите искомое число");
// int num = Convert.ToInt32(Console.ReadLine());
// int[] array = CreatRandArray(size, minValue, maxVaiue);

// FindNumInaArray(array, num);// не получается вывести ответ в консоль.

//            Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
//значения которых лежат в отрезке [10,99].

// int ElementsCount(int[] array)//считает кол-во эл-ов в отрезке
// {
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if(array[i] >- 10 && array[i] <- 99)
//         count++;
//     }
//     return counnt;
// }
//     //остальное дописать.