/*
Перевод двоичного в десятичное
*/

string? GetNumber(string description){
    Console.Write($"{description} => ");
    string? number = Convert.ToString(Console.ReadLine());
    return number;
}

int Convert2to10(string number){
    int temp = 0;
    Console.WriteLine(number);
    for (int i = 0; i < number.Length; i++)
    {
        if(number[i] == '1')
            temp = (temp*2) + 1;
        else 
            temp = (temp*2);
        Console.WriteLine(temp);
    }

    return temp;
}

Console.Clear();

string? number = GetNumber("Input number: ");
Console.WriteLine($"Byte number {number} is {Convert2to10(number)}");
