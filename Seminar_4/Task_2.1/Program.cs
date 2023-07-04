/*Задача 26: Напишите программу, которая принимает на вход число и
 выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
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
int number = GetNumber("Input number: ");

int count = (int)Math.Log10(number)+1;
Console.WriteLine(count);