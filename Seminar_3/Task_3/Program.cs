//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве. 
// 
//A (3,6); B (2,1) -> 5,09  
//A (7,-5); B (1,-1) -> 7,21 
 
//c = root (x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) 
 
void Print (string text){  
   Console.WriteLine(text); 
} 
 
 
int GetIntNumber(){ 
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number; 
} 
 
double FindDistance (int x1, int y1, int x2, int y2){
    int pow = 2; 
    double result = Math.Sqrt(Math.Pow((x2-x1), pow) + Math.Pow((y2-y1),pow)); 
 
    return result; 
} 
 
Print("Insert one by one x1, y1, x2, y2 :"); 
int x1 = GetIntNumber(); 
int y1 = GetIntNumber(); 
int x2 = GetIntNumber(); 
int y2 = GetIntNumber(); 
 
double result = FindDistance(x1, y1, x2, y2); 
Print($"Distance between points is {result}");