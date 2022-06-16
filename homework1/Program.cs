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
/*

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

*/

//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
Console.WriteLine("Введите число: ");
int namber = int.Parse(Console.ReadLine());

if( namber % 2 == 0)
{
    Console.WriteLine($"число {namber} - четное число");
}
else
{
    Console.WriteLine($"число {namber} - нечетное число");

}
*/

//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int namber = 1;

while(namber <= N)

{
    Console.WriteLine($"{namber = namber+1}");
    namber++;
}

*/