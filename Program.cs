/* Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84; A (7,-5, 0); B (1,-1,9) -> 11.53


int x1 = ReadInt("input х for point 1: ");
int y1 = ReadInt("input y for point 1: ");
int z1 = ReadInt("input z for point 1: ");
int x2 = ReadInt("input х for point 2: ");
int y2 = ReadInt("input y for point 2: ");
int z2 = ReadInt("input z for point 2: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z2 - z1;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine("distance = " + length);


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/

/* Задача 3
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27; 5 -> 1, 8, 27, 64, 125  */

int number = ReadInt("Введите число: ");

for (int i = 1; i <= number; i++)
{
    Console.Write($"{i * i * i}, ");
}

// Метод
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
