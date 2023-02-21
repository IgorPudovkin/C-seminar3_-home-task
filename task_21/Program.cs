// Задача 21. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
int x1 = ReadInt("enter coordinate X first point: ");
int y1 = ReadInt("enter coordinate Y first point: ");
int z1 = ReadInt("enter coordinate Z first point: ");
int x2 = ReadInt("enter coordinate X second point: ");
int y2 = ReadInt("enter coordinate Y second point: ");
int z2 = ReadInt("enter coordinate Z second point: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Length of segment {length}");
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
