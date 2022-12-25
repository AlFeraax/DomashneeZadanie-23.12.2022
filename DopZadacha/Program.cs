// Дополнительная задача.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int x = number;
string chislo = Convert.ToString(x, 2);

Console.WriteLine($"В двоичной системе число {number} записывается как {chislo}.");