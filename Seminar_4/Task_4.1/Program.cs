/*Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void FillArray(int[] array){

    int length = array.Length;
    int index = 0;
    while(index<length){
        array[index] = new Random().Next(0, 2);
        index ++;
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

int [] array = new int [8];
FillArray(array);