Random rand = new Random();
int number = rand.Next(10,100);
Console.WriteLine($"Our number is {number}");
int first = number / 10;
int second = number % 10;
if (first > second)
    Console.WriteLine($"Biggest is {first}");
else
    Console.WriteLine($"Biggest is {second}");