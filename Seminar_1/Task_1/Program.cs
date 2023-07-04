
Console.Write("Input number: ");
int number =Convert.ToInt32(Console.ReadLine());
//int squareNumber = number*number;

int power = 2;//power of number
int squareNumber = (int)Math.Pow(number, power);
Console.WriteLine ($"Square {number} is {squareNumber}");