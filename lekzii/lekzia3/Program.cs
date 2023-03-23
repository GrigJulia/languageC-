// void metod1()
// {
//     Console.WriteLine("avtor ...");
// }
// metod1();

// void metod2(string msg) //не возвр. но принимают
// {
//     Console.WriteLine(msg);
// }
// metod2("Tekst soobchenia");

// void metod21(string msg, int count) //не возвр. но принимают
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
    
// metod21("Tekst soobchenia", 4);//metod21(msg: "tekst", count: 4); при именовании аргументов, можнописат их не по порядку.

//int Metod3()
//{
//    return DateTime.Now.Year;
//}
//int year = Metod3();
//Console.WriteLine(year);

// string metod4(int count, string tekst)
// {
//     int i = 0;
//     string result = String.Empty;
//     while (i < count)
//     {
//         result = result + tekst;
//         i++;
//     }
//     return result;
// }
// string res = metod4(10, "ky-ky ");
// Console.WriteLine(res);

// string metod4(int count, string tekst)
// {
//     string result = String.Empty;
//     for (int i = 0; i < count; i++) // большая часть задач используют фор
//     {
//         result = result + tekst;
        
//     }
//     return result;
// }
// string res = metod4(10, "ky-ky ");
// Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)//   цикл в цикле таблица умножения
// {
//     for (int j = 2; j < 10; j++)
//     {
//         Console.WriteLine($"{i} x {j} = {i * j}");
//     }
//     Console.WriteLine();
// }

//Заменить пробелы на чёрточки, к на К, С на с.
//string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
//               + "ежели бы вас послали вместо нашего милого Винценгероде,"
//               +"вы бы взяли приступом согласие прусского короля. "
//               +"Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3] // r                 Чтобы получить конкретный символ

// string Replace(string text, char oldValue, char newValue)// здесь стринг, потому что возвращаем строку.
// {
//     string result = String.Empty; // инициализация пустой строки
//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text [i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);

//        Cортиовка массивов.
// int[] arr ={ 1, 5, 4, 3, 2, 6, 7, 1, 1 };// эллементы массива могут повторяться. Массив

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)//проходим по всем элементам массива и выводим на экран
//     {
//         Console.Write($"{array[i]}");
//     }
//     Console.WriteLine();
// }
// void SelectionSort(int[] array) //метод который упорядочиввает массив
// {
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int minPosition = i;

//         for (int j = i + 1; j < array.Length; j++)//начинаем сортировку с того эл-та который ещё не отсортированпоэтому i+1
//         {
//             if(array[j] < array[minPosition]) minPosition = j;//ищим мин элемент. смотрим текущий если он меньше того эл. кот мы предплог,то нужно эту позицию сохранить.
//         }//блок кода ищет макс эл.

//         int temporary = array[i];//рабочая позиция
//         array[i] = array[minPosition]; //здесь кладём найденный элемент
//         array[minPosition] = temporary;//в мин позицию кладём элемент кот был временным

//     }

// }

// PrintArray(arr);
// SelectionSort(arr);
// PrintArray(arr);

//Зад1 программа принимает на вход координаты точки (Х и Y), причём X не равно 0 и Y  не равно 0 и выдаёт номер четверти.
// int FindQart(int x, int y)
// {
//     if(x > 0 && y > 0)
//     return 1;
//     if(x < 0 && y > 0)
//     return 2;
//     if(x < 0 && y < 0)
//     return 3;
//     if(x > 0 && y < 0)
//     return  4;

//     return 0;
// }

// Console.WriteLine("input x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Point Locate at {FindQart(x, y)} quart");//Console.WriteLine(FindQart(x, Y));