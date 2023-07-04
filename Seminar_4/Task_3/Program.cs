/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int GetNumber(string description){

    int number;
    Console.WriteLine($"{description} => ");

    while(true){
        string? temp = Console.ReadLine();
        if(int.TryParse(temp, out number)){
            return number;
        }
        Console.Write($"This number {temp} is not correct. Try again. => ");
    }
}

int GetMultiplication(int number)
{
    int mult = 1; 
    for (int i = 1; i <= number; i++)
    {
        mult *= i;
    }
    return mult;
}

int number = GetNumber("Input number: ");
int mult = GetMultiplication(number);

Console.WriteLine($"Result is {mult}");