Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());


if (x == 0 || y == 0)
{
    Console.WriteLine("x или y не должны равняться 0");

}
else if (x > 0 && y > 0)
{
    Console.WriteLine("1 четверть");

}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2 четверть");

}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3 четверть");

}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4 четверть");

}