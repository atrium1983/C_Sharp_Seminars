/*
Reverse massive
*/

int[] CreateArray(int size, int min, int max){ 
    int[] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max);
    }

    return array;
}

string PrintArray(int [] array){
    return string.Join(", ", array);
}

void Reverse(int [] array){
    int size = array.Length;

    for (int i = 0, j = size - 1; i < j; i++)
    {
        (array[i], array[j]) = (array[j], array[i]);
    }
}

int [] array = CreateArray(7,-9,9);
Console.WriteLine($"Init array is {PrintArray(array)}");
Reverse(array);
Console.WriteLine($"Reverse array is {PrintArray(array)}");