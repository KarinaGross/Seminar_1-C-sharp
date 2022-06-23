// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
// a = 25, b = 5 -> да
Console.Write("Input first number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2 * number_2)
{
    Console.WriteLine("a =" + number_1 + ", b = " + number_2 + " ->" + " yes");
}
else
{
    Console.WriteLine("a =" + number_1 + ", b = " + number_2 + " ->" + " no");
}