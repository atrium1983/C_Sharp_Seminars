/*
Напишите программу, которая будет преобразовывать десятичное число 
в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

Console.Clear();
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

/*string FindByteNumber(int number){
    string i = String.Empty;
    while(number > 0){
        i = i.Insert(0, Convert.ToString(number%2));
        number/= 2;
    }
    return i;  
}
*/

string FindByteNumber(int number){
    string count = String.Empty;
    while(number > 0){
        int temp = number%2;
        count = Convert.ToString(temp) + count; // Перемена мест слагаемых (к символу прибавляем накапливаемый результат).
        number = number/2;
    }
    return count;
}

string a = FindByteNumber(number);
Console.WriteLine(a);
