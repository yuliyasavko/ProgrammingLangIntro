Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int a = 7;
int b = 23;

if ( number % a == 0 && number % b == 0)
{
    Console.WriteLine($"{number} делится на {a} и {b}");

}
else
{
    Console.WriteLine($"{number} не кратно {a} и {b}");
}
