// Написать программу, которая на вход принимает число и выдает его квадрат.

// Запрашиваем у пользователя число
Console.Write("Введите число: ");

// Создаем переменную num и сохраняем в нее значение, введенное из консоли
int num = Convert.ToInt32(Console.ReadLine());

// Выводим значение переменных num и num^2
Console.WriteLine(num + " -> " + num * num);