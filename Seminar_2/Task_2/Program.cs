int GetNumber (int num)
{
    Console.WriteLine(num + " => ");
    int num1 = num/100;
    int num2 = num%10;
    int num3 = num1*10 + num2;

    return num3;
}

int newRand = new Random().Next(100,1000);
int result = GetNumber(newRand);
Console.WriteLine(result);
