// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNumb = Convert.ToInt32(Console.ReadLine());



if (firstNumb == secondNumb & firstNumb == thirdNumb)
{
    Console.WriteLine("Эти числа равны!");
}
else
{
    if (firstNumb >= secondNumb)
    {
        if (firstNumb >= thirdNumb)
        {
            Console.WriteLine($"Максимальное число => {firstNumb}");
        }
        else
        {
            Console.WriteLine($"Максимальное число => {thirdNumb}");
        }
    }
    else if (secondNumb >= firstNumb)
    {
        if (secondNumb >= thirdNumb)
        {
            Console.WriteLine($"Максимальное число => {secondNumb}");
        }
        else
        {
            Console.WriteLine($"Максимальное число => {thirdNumb}");
        }
    }

}