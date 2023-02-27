// Написать программу, которая принимает на вход число и выдает сумму цифр в числе.
int Prompt(string message)
{
    System.Console.Write(message); // Выводим приглашение ко вводу
    string readInput = System.Console.ReadLine();
    int result = int.Parse(readInput); // приводим к числу
    return result; // возвращаем результат
}

int SumAllDigit(int number)
{
   int result = 0;
   while (number > 0)
  {
    result += number % 10;
    number = number / 10;
  }
  return result;
}

int number = Prompt("Введите число: ");
System.Console.WriteLine($"Сумма всех чисел в цифре {number} = {SumAllDigit (number)}");

