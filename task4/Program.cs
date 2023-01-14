System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());



if (number > 1) {
    if (number % 2 == 0)
    {
        while (number > 1)
        {
            System.Console.WriteLine(number);
            number -= 2;
        }
    }
    else
    {
        number -= 1;
        while (number > 1)
        {
            System.Console.WriteLine(number);
            number -= 2;
        }
    }
}
else
{
System.Console.WriteLine("Нужно вводить числа больше 1");
}