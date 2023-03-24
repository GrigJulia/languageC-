//             Задача 1. Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

// int Findsum(int num)
// {
//     int sum = 0;
//     for (int current = 1; current <= num; current++)    
//     {
//         sum += current;//sum = sum + current;тоже самое!
//     }
//     return sum;
// }

// Console.WriteLine ("input A:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Findsum(a));

//            Задача 4. Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0] Один метод будет: генерир массив с заданным размере. генер массив в нужных нам значениях. Другой будет его выводить.
//массив это цикл for

// int[] CreatRandArray (int size, int minValue, int maxVaiue)//cjplf`n vfccbd
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

// Console.WriteLine ("input aaray size:");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input minimal value array ellement");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("input maximal value of array element:");
// int maxVaiue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreatRandArray(size, minValue, maxVaiue));//вызов методов криэйт возвращает массив, шоурей принимает 

//      Задача 2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

//       Задача 3. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24
//5 -> 120

// int Factorial(int n)
// {
//     int F = 1;
//     for (int i = 1; i <= n; i++)   
//         F *= i;
//         return F;
// }
// Console.WriteLine("input N");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Factorial {n} is {Factorial(n)}");