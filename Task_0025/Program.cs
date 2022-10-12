// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

System.Console.WriteLine("Введите целое число A: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите целое число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int b2 = b;
int a2 = a;
while (b > 1)
{
    b = b - 1;
    a = a * a2;
}
Console.WriteLine($"{a2} в степени {b2} = {a}");