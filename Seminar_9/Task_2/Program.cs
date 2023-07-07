/*
Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/

//First option
string ReturnRealDigits(int startNum, int number){
    if(startNum == number) return startNum.ToString();
    return startNum + " " + ReturnRealDigits(startNum+1,number); // " " для преобразования всего рядом в string
}
Console.Clear();
Console.WriteLine(ReturnRealDigits(1,5));

//Second option
void Print(int number){
    if(number > 1) Print(number-1);
    Console.Write(number);
}

Print(5);
