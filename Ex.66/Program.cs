// Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetSumOfNumbers(int firstNumber, int lastNumber)
{
    if (lastNumber == firstNumber) return lastNumber;
    return firstNumber + GetSumOfNumbers(firstNumber + 1, lastNumber);
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите число M: ");
int n = GetInput("Введите число N: ");
Console.Write($"M = {m}; N = {n} -> ");
Console.WriteLine($"{GetSumOfNumbers(m,n)}");