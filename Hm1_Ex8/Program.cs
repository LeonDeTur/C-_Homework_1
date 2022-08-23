Console.WriteLine("Введите число");
int num_a = Convert.ToInt32(Console.ReadLine());
int num_car = 0;

Console.WriteLine("Чётные числа от " + num_car + " до " + num_a + ":");

while (num_car < num_a - 1)
{
    num_car += 2;
    Console.WriteLine(num_car);
}
