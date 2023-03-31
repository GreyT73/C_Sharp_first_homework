//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число для задачи 8:");
string firstNumber = Console.ReadLine();
int task8FirstNumber = Convert.ToInt32(firstNumber);
int lineOfNumbers = 2;
if (task8FirstNumber >= 2)
{
    Console.WriteLine("Ответ на 8 задачу: ");
    while (lineOfNumbers <= (task8FirstNumber-2))
    {
        Console.Write($"{lineOfNumbers}, ");
        lineOfNumbers += 2;
    }
    Console.Write(lineOfNumbers);
}
else
{
    Console.WriteLine("Ответ на 8 задачу: ");
    Console.WriteLine($"Нет положительных четных чисел до {task8FirstNumber}");
}