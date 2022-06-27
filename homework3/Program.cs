// 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


/*Console.Write("Imput namber N: ");
int N = int.Parse(Console.ReadLine());
int resalt = 1;

while(resalt <= N)
{
    Console.WriteLine(Math.Pow(resalt, 3));
    resalt++;
}
*/

// 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.Write("Imput 5-digit number: ");
int number = int.Parse(Console.ReadLine());
int A = number/10/10/10/10;
int B = number/10 / 10 / 10 % 10;
int C = number/10 % 10;
int D = number % 10;

if(A == D && B == C)
{
    Console.WriteLine($"The number of polindroms entered");
}
else
{
    Console.WriteLine($"The number entered is not a polindroms");

}
*/

// 23  Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 3D пространстве.

/*Console.WriteLine("Imput the coordinates of the two points: ");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());

int length = (int) Math.Pow(x2-x1,2) + (int) Math.Pow(y2-y1,2) + (int) Math.Pow(z2-z1,2);
double resalt = Math.Sqrt(length);
Console.WriteLine($"The distance between two points is equal to {resalt}");
*/








