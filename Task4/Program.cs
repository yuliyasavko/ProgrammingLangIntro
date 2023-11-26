Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 0 )
{
    Console.WriteLine("Число должно быть >= 0");

}
else 
{
    if (number < 10)
    {
        Console.WriteLine($"{number}");
    }
    else 
    {
        while (number >= 10) {
            int n = number % 10;
            Console.Write($"{n}, ");
            number = number / 10;
        }
        Console.WriteLine($"{number}");
    }

}