using System;

class Program
{
    delegate string GetNextDayOfWeek();

    static void Main(string[] args)
    {
        string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        int currentDayIndex = 0;

        GetNextDayOfWeek getNextDay = () =>
        {
            currentDayIndex = (currentDayIndex + 1) % 7;
            return daysOfWeek[currentDayIndex];
        };

        // Вызываем делегат 10 раз
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(getNextDay());
        }
    }
}
