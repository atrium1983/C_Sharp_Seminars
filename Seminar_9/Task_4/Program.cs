/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int GetPowNumber(int number, int pow){
    if(pow == 0) return 1; 
        return number * GetPowNumber(number, pow-1);
}
Console.Clear();
Console.WriteLine(GetPowNumber(3,1));