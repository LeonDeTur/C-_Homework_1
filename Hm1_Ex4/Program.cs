Console.WriteLine("Введите первое число");
int num_a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int num_b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int num_c = Convert.ToInt32(Console.ReadLine());
int num_max = 0;
if ((num_a == num_b) || (num_b == num_c) || (num_a == num_c))
{
Console.WriteLine("Одно или более чисел равны. Большее число невозможно найти. Введите другие числа.");
}
else
{    
    if (num_b < num_a)
    {
        num_max = num_a;    
    }
    else
    {
        num_max = num_b;    
    }

    if (num_max < num_c)
    {
    num_max = num_c;
    Console.WriteLine("Наибольшее число:");
    Console.WriteLine(num_max);
    }
    else
    {
    Console.WriteLine("Наибольшее число:");
    Console.WriteLine(num_max);
    }
}