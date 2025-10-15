int[] numbers = [1, 2, 3, 4, 5];
//int[] newNumbers = RemoveElement(numbers, 22);
int[] newNumbers = Add(numbers, 6);
newNumbers = Add(newNumbers, 7);
newNumbers = Add(newNumbers, 8);

newNumbers = Remove(newNumbers, 3);
newNumbers = Remove(newNumbers, 3);
newNumbers = Remove(newNumbers, 4);
newNumbers = Remove(newNumbers, 5);

foreach (var item in newNumbers)
    Console.WriteLine(item);

//int max = FindMax(numbers);
//int min = FindMin(numbers);
//Console.WriteLine(max);
//Console.WriteLine(min);

//string[] names = ["Tom", "Bob", "Sam"];
//string[] newNames = CopyArray(names);

//foreach (var item in newNames)
//    Console.WriteLine(item);



static int[] Add(int[] array, int element)
{
    Array.Resize(ref array, array.Length + 1);
    array[array.Length - 1] = element;
    return array;
}


static int[] Remove(int[] array, int element)
{
    for (int i = 0; i < array.Length; i++)
    {

        if (array[i] == element)
        {
            int[] newArray = RemoveElement(array, i);
            return newArray;
        }

    }

    Console.WriteLine("Element is not found");
    return array;
}


static int[] RemoveElement(int[] array, int index)
{

    if (index > array.Length - 1)
    {
        Console.WriteLine("Out of range ");
        return array;
    }

    int[] newArray = new int[array.Length - 1];


    int secondIndexer = 0;
    for (int i = 0; i < array.Length ; i++)
    {
        if (i != index)
        {
            newArray[secondIndexer] = array[i];
            secondIndexer++;
        }
    }

    return newArray;
}


static string[] CopyArray(string[] array)
{
    string[] newArray = new string[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        newArray[i] = array[i];
    }

    return newArray;

}

static int FindMax(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("array is empty");
        return 0;
    }

    int max = array[0];

    foreach (var item in array)
    {
        if (max < item)
            max = item;
    }

    return max;
}
static int FindMin(int[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("array is empty");
        return 0;
    }

    int min = array[0];

    foreach (var item in array)
    {
        if (min > item)
            min = item;
    }

    return min;
}

