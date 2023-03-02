// Task1.  Напишите программу, которая на вход принимает два числа
// и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int max = number1;
int min = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number1 < min) min = number1;
if (number2 < min) min = number2;

Console.Write("max = ");
Console.Write(max);

Console.Write("min = ");
Console.Write(min);
*/

// Task2. Напишите программу, которая принимает на 
//вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number1 > max) max = number1;
if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("max = ");
Console.Write(max);
*/

// Task3. Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int current = number % 2; 

if (current == 0)
{
    Console.WriteLine("Yes!");
}
else
{
    Console.WriteLine("No!");
}
*/

// Task4. Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}



