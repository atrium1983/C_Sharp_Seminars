/*
//прямая рекурсия
void Print (int value){
    Console.WriteLine(value);
    if (value <5)   Print(value+1);
}

Print(1);

//обратная рекурсия
void Print (int value){
    if (value <5)   Print(value+1);
    Console.WriteLine(value);
}

Print(1);
*/

int SumDigit (int number){
    if(number == 0) return 0;
        return number%10 + SumDigit(number/10);
}

Console.WriteLine(SumDigit(45));
