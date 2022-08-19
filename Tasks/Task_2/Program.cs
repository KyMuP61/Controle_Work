void FindeIndex(string[] array)
{

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            Console.Write($"{array[i]}, ");
        }
    }
}
string[] array = { "1234", "1567", "-2", "computer science" };
FindeIndex(array);