//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите второе число для задачи 2:");
string firstNumber = Console.ReadLine();
int task2FirstNumber = Convert.ToInt32(firstNumber);
Console.WriteLine("Введите второе число для задачи 2: ");
string secondNumber = Console.ReadLine();
int task2SecondNumber = Convert.ToInt32(secondNumber);
Console.WriteLine("Ответ на Задачу 2:");
if (task2FirstNumber > task2SecondNumber)
{
    Console.WriteLine($"{task2FirstNumber} большеее число, а {task2SecondNumber} - меньшее");
}
else if (task2FirstNumber < task2SecondNumber)
{
    Console.WriteLine($"{task2SecondNumber} больше число, а {task2FirstNumber} - меньшее");
}
else
{
    Console.WriteLine("Вы ввели одинаковые числа");
}