// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

System.Console.WriteLine("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (num >= 1)
{
    sum = sum + (num % 10);
    num = (num - num % 10) / 10;
}
System.Console.WriteLine($"сумма цифр в числе = {sum}");