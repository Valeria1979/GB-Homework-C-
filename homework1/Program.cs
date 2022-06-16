//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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



