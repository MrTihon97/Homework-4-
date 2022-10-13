// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Degree(int A, int B)
{
    int result = 1;
    for (int index = 1; index <= B; index++)
    {
        result = result * A;
    }
    return result;
}

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

int degree = Degree(A, B);
if (A>0 && B>0)
{
Console.WriteLine($"Ответ:{degree}");
}
else Console.Write("Не целые положительные числа или ноль");