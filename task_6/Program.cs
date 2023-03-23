//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число для задачи 6:");
string firstNumber = Console.ReadLine();
int task6FirstNumber = Convert.ToInt32(firstNumber);

if (task6FirstNumber % 2 == 0)
{
    Console.WriteLine("Ответ на задачу 6: ");
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Ответ на задачу 6: ");
    Console.WriteLine("Число нечетное");
}
