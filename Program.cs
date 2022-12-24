void write_arr(string[] arr)
{
    Console.Clear();
    Console.WriteLine("Массив строк");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"{i + 1}: {arr[i]}");
    }
}

string[] feel_arr(string[] arr)
{
    Console.Clear();
    Console.WriteLine("Введите элементы массива");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{i+1}: ");
        arr[i] = Console.ReadLine();
    }
    Console.Clear();
    return arr;
}

void algorithm(string[] arr)
{
    int count = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
            Console.WriteLine($"{count++}: {arr[i]}");
    }
}

void start()
{
    Console.Write("Введите размерность массива: ");
    string[] arrString = new string[int.Parse(Console.ReadLine())];
    feel_arr(arrString);
    write_arr(arrString);
    Console.WriteLine("\nВыполнение алгоритма");
    algorithm(arrString);
}

start();