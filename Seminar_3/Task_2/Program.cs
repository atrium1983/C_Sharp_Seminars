//Вввести номер четверти системы координат и вывести в каких координатах эта четверть находится

void Print (string text){  
   Console.WriteLine(text); 
} 
 
 
int GetIntNumber(){ 
    int number = Convert.ToInt32(Console.ReadLine()); 
    return number; 
} 
 
void FindCoordinate (int number){ 
    if (number > 0 && number < 5){ 
      
        switch (number) 
        { 
            case 1: Print("X > 0, Y > 0"); 
            break; 
 
            case 2: Print("X < 0, Y > 0"); 
            break; 
 
            case 3: Print("X < 0, Y < 0"); 
            break; 
 
            case 4: Print("X > 0, Y < 0"); 
            break; 
        } 
    } 
    else{ 
        Print("Insert correct number"); 
    } 
} 
 
Print("Input quarter"); 
int number = GetIntNumber(); 
FindCoordinate(number);
