// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите превое число: ");
int firstNumb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumb = Convert.ToInt32(Console.ReadLine());

if(firstNumb != secondNumb) {
if (firstNumb > secondNumb) {
Console.WriteLine($"Большее число => {firstNumb}");
} 
else if(firstNumb < secondNumb) {
    Console.WriteLine($"Большее число => {secondNumb}");
}
} else {
    System.Console.WriteLine("Эти числа равны!");
}

