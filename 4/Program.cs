//Показать четные числа от 1 до N
void even_n(int num1)
{
    int num2 = 2;
    while (num2 <= num1)
    {
        Console.WriteLine(num2);
        num2 = num2 + 2;
    }
}
int n;
Console.Write("Введите натуральное число: ");//5, 8
n = Convert.ToInt32(Console.ReadLine());
even_n(n);