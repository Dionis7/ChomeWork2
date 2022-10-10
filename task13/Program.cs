Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
string numberS = Math.Abs(number).ToString();

Console.WriteLine(numberS.Length > 2 ? $"{number} -> {numberS[2]}" : $"{numberS} -> третьей цифры нет");