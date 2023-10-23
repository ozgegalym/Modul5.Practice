using System;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MethodA();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение было обработано в вызывающем методе: {ex.Message}");
            }
        }

        static void MethodA()
        {
            try
            {
                MethodB();
            }
            catch (Exception ex)
            {
                // Поднимаем исключение в вызывающий метод
                throw new Exception("Исключение было поднято в вызывающий метод", ex);
            }
        }

        static void MethodB()
        {
            // Генерируем исключение
            throw new InvalidOperationException("Исключение было сгенерировано в вызываемом методе.");
        }
    }
}
