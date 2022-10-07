Console.WriteLine("Введите первое число");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num_b = Convert.ToInt32(Console.ReadLine());

if (num_a < num_b)
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num_b);
}
else
{
if (num_b < num_a)
{
    Console.WriteLine("Большее число:");
    Console.WriteLine(num_a);
}
else
{
    Console.WriteLine("Числа равны");
}
}