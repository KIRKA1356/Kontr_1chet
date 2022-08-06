Console.WriteLine("Введите кол-во слов, которое будете вводить");
int size = Convert.ToInt32(Console.ReadLine());

string[] Array(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void ShowArray(string[] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            Console.Write('"' + array[i] + '"' + " ");
    }
    Console.WriteLine();
}

string[] MyArray = Array(size);
ShowArray(MyArray);