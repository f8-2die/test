using System;
public class MainClass
{
    public static void Main()
    {
        for (int i = 0; i < 1;)
        {
            Console.WriteLine("Введите число 1:");
            int numberOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2:");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"a + b = {numberOne + numberTwo}");
                    break;
                case "-":
                    Console.WriteLine($"a - b = {numberOne - numberTwo}");
                    break;
                case "*":
                    Console.WriteLine($"a * b = {numberOne * numberTwo}");
                    break;
                case "/":
                    Console.WriteLine($"a / b = {numberOne / numberTwo}");
                    break;
            }
            Console.WriteLine("Хотите продолжить выполнение программы?");
            Console.WriteLine("ДА - 1. НЕТ - 2.");
            string responseUser = Console.ReadLine();
            if (responseUser == "1")
            {
                continue;
            }
            else if (responseUser == "2")
            {
                break;
            }
        }
    }
}