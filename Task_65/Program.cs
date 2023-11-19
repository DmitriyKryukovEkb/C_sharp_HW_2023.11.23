// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string msg) 
{
    System.Console.WriteLine(msg); 
    int inputNumber = Convert.ToInt32(Console.ReadLine()); 
    return inputNumber; 
}

int NumbersSum(int startNumber, int endNumber)
{
    if (startNumber < endNumber)
    {
        return startNumber + NumbersSum(startNumber + 1, endNumber);
    }
    else
    {
        return startNumber;
    }
}


Console.WriteLine($"Сумма натураьных чисел внутри диапазона: {NumbersSum(ReadInt("Введите начало диапазона M: "), ReadInt("Введите конец диапазона N: "))}");