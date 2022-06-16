//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число: ");
int namberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int namberВ = int.Parse(Console.ReadLine());

if(namberA > namberВ)
{
    Console.WriteLine($"число {namberA} - максимальное число {namberВ} - минимальное число");

}

else
{
    Console.WriteLine($"число {namberA} - минимальное число {namberВ} - максимальное число");

}

*/

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int namberA = int.Parse(Console.ReadLine());
int namberB = int.Parse(Console.ReadLine());
int namberC = int.Parse(Console.ReadLine());
int max = namberA;

if(namberB > max) max = namberB;

if(namberC > max) max = namberC;

{
    Console.WriteLine($"число {max} - максимальное число");
}

