// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1 > number2)
{
    Console.WriteLine("Первое число больше второго");
}
else if (number1 < number2)
{
    Console.WriteLine("Первое число меньше второго");
}
else
{
    Console.WriteLine("Оба числа равны");
            }
Console.ReadKey();