// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
int Reverse(int number) 
{
    int result = 0;

    while (number > 0) {
        int digit = number % 10;
        result = result * 10 + digit;
        number /= 10;
    }

    return result;
}
Console.WriteLine("Enter number");
int OriginalNumber = Convert.ToInt32(Console.ReadLine());
int ReverseNumber = Reverse(OriginalNumber);
if (OriginalNumber == ReverseNumber)
{
    Console.WriteLine ("Число палиндром");
}
else
{
    Console.WriteLine("Число не палиндром");
}
*/
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.WriteLine("Введите координаты первой точки X: ");
int X1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки Y: ");
int Y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки Z: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки X: ");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки Y: ");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки Z: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

int A = X2 - X1;
int B = Y2 - Y1;
int C = Z2 - Z1;

double Length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Искомая длинна: {Length}");
*/
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Cubing (int N)
{
    int result = 1;
    while (result <= N)
        {
        Console.Write(Math.Pow(result,3) + " ");
        result++;
        }
}
Console.WriteLine("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
Cubing(N);

*/

