void printarray(int[] array)
{
    for(int i = 0; i<(array.Length-1); i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length-1] + ". ");
}

void fillarray(int[] array, int min , int max)
{
    Random rand = new Random();
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = rand.Next(min, max+1);
    }
}

int[] array = new int[8];

Console.Write("Max number of array: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.Write("Min number of array: ");
int min = Convert.ToInt32(Console.ReadLine());

fillarray(array, min, max);
printarray(array);