// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// Console.Write("Imput namber A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.Write("Imput namber B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int count = 1;
// int resalt = A;

// while (count < B)

// {
//     count++;
//     resalt = resalt * A;

// }
// Console.WriteLine(resalt);



// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// void SumOfNumbersIter(int N)
// {
//     int sum = 0;

//     while (N > 0)
//     {
//     sum = sum + N % 10; 
//     N = N / 10;
//     }
//     Console.WriteLine(sum);
// }

// Console.WriteLine("Input N: ");
// int a = int.Parse(Console.ReadLine());

// SumOfNumbersIter(a);


// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//         Console.Write(array[i] + " ");
// }

// int[] myRandomArray = CreateRandomArray(8, 1, 8);
// ShowArray(myRandomArray);

// Console.WriteLine();

