// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int ReadInt(string msg) 
{
    System.Console.WriteLine(msg); 
    int inputNumber = Convert.ToInt32(Console.ReadLine()); 
    return inputNumber; 
}

string EverySecondNumbersString(int startNumber, int endNumber)
{
    if (startNumber < endNumber - 1)
    {
        return startNumber + ", " + EverySecondNumbersString(startNumber + 2, endNumber);
    }
    else
    {
        return startNumber.ToString();
    }
}

int NextEvenNumber(int inputNumber)
{
    if (inputNumber % 2 == 0)
    {
        return inputNumber;
    }
    else
    {
        return inputNumber + 1;
    }
}

Console.WriteLine(EverySecondNumbersString(NextEvenNumber(ReadInt("Введите начало диапазона M: ")), ReadInt("Введите конец диапазона N: ")));