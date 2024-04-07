using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        try
        {
            // Запускаем блокнот
            Process.Start("notepad.exe");
            Console.WriteLine("Блокнот запущен.");

            // Запускаем Paint
            Process.Start("mspaint.exe");
            Console.WriteLine("Paint запущен.");

            // Запускаем калькулятор
            Process.Start("calc.exe");
            Console.WriteLine("Калькулятор запущен.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Произошла ошибка при запуске приложений: " + e.Message);
        }
    }
}
