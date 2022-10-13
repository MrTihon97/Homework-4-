// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите целое положительное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    int counter = Convert.ToString(num).Length;
    int sum = 0;
    int result = 0;

    for (int index = 0; index < counter; index++)
    {
        sum = num - num % 10;
        result = result + (num - sum);
        num = num / 10;
    }
    return result;
}

int sumNumber = SumNumber(num);
if (num > 0)
{
    Console.WriteLine($"Сумма цифр в числе {num} = {sumNumber}");
}
else Console.WriteLine("не целое положительное число или ноль");