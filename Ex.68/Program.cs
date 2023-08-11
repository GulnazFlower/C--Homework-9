// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetAckermanFunction(int number1, int number2)
{
    if (number1 == 0) return number2 + 1;
    if ((number1 != 0) && (number2 == 0)) 
    return GetAckermanFunction(number1 - 1, 1);
    else return GetAckermanFunction(number1 - 1, GetAckermanFunction(number1, number2 - 1));
}

int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetInput("Введите неотрицательное целое число M: ");
int n = GetInput("Введите неотрицательное целое число N: ");
Console.Write($"M = {m}; N = {n} -> A(m,n) = ");
Console.WriteLine($"{GetAckermanFunction(m,n)}");