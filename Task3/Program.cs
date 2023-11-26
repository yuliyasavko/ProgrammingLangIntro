Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 10;
int b = 99;

if (number < a || number > b)
{
    Console.WriteLine($"Число должно быть от {a} до {b}");

}
else 
{
    int x = number / 10;
    int y = number % 10;

    if (x < y)
    {
        Console.WriteLine($"{y}");
    }
    else 
    {
        Console.WriteLine($"{x}");
    }
}
