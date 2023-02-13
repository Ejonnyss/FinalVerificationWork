Console.Clear();

Console.WriteLine("Введите число элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] array = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент: ");
    array[i] = Convert.ToString(Console.ReadLine());
}
Console.WriteLine();

int count = 0;
int limit = 3;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= limit) count++;
}

string[] editedArray = new string[count];
int j = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= limit)
    {
        editedArray[j] = array[i];
        j++;
    }
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Исходный массив:");
ShowArray(array);
Console.WriteLine();


Console.WriteLine("Отредактированный массив:");
ShowArray(editedArray);