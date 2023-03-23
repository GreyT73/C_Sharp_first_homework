//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число для задачи 4:");
string firstNumber = Console.ReadLine();
int task4FirstNumber = Convert.ToInt32(firstNumber);
Console.WriteLine("Введите второе число для задачи 4:");
string secondNumber = Console.ReadLine();
int task4SecondNumber = Convert.ToInt32(secondNumber);
Console.WriteLine("Введите третье число для задачи 4:");
string thirdNumber = Console.ReadLine();
int task4ThirdNumber = Convert.ToInt32(thirdNumber);
int max = task4FirstNumber;
if (task4SecondNumber > max)
{
    max = task4SecondNumber;
}
if (task4ThirdNumber > max)
{
    max = task4ThirdNumber;
}
Console.WriteLine("Ответ на задачу 4:");
Console.WriteLine($"Максимальным числом является {max}");
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).



//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
