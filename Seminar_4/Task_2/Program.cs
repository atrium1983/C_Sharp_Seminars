//Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5

int GetNumber()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int DigitsNumber(int number)
{
    int count = 0;
    while (number > 0)
    {
        number /= 10; // Отбрасываем последнюю цифру, меняем разрядность.
        count++;
    }
    return count;
}

Console.Write("Insert number = > ");
int number = GetNumber();
int count = DigitsNumber(number);

Console.WriteLine($"Number of digits is {count}");