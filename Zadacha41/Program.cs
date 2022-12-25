//Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Введите некоторое колличество чисел больше или меньше нуля: ");
int[] numbers = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Вы ввели {count} чисел больше нуля.");