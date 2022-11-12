int[] Array = new int[8];
FillArray (Array);
PrintArray (Array);


void FillArray(int[] Array)
{
    int length = Array.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine ("Введите число:");
        Array[index] = int.Parse (Console.ReadLine ()!);
        index++;
    }
}

void PrintArray(int[] Array)
{
    Console.Write("Массив:[ ");
    int count = Array.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(Array[position] + " ");
        position++;
    }
    Console.WriteLine("]");
}

