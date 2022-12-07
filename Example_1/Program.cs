

// Напишите программу, которая принимает на вход два числа (A и B) и метод который возводит число A в натуральную степень B. 
// Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать Math.Pow()


int numberA = ReadInt("Введиче число А: ");
int numberB = ReadInt("Введите число В: ");
int resultExponentiationMethod = ExponentiationMethod(numberA, numberB);

Console.WriteLine(resultExponentiationMethod);

int ExponentiationMethod(int numberA, int numberB)
{ 
    int result = 1;

    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }

    return result; 
}

// Функция ввода
int ReadInt(string massage)
{
    Console.WriteLine(massage);
    return Convert.ToInt32(Console.ReadLine());
}