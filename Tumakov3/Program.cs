namespace Tumakov3;
class Program
{
    static void Main()
    {
        //упражнение 4.1-4.2
        Console.WriteLine("\tУпражнение 4.1, 4.2\t");
        Console.Write("Введите номер дня в году (от 1 до 365): ");

        if (int.TryParse(Console.ReadLine(), out int dayNum) == false)
        {
            Console.WriteLine("Ошибка, введите число");
        }
        else if (dayNum < 1 || dayNum > 365)
        {
            Console.WriteLine("Ошибка, введите число от 1 до 365");
        }
        else
        {
            int[] dayMonths = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] monthNames = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
            byte monthsIndex = 0;

            while (dayNum > dayMonths[monthsIndex])
            {
                dayNum -= dayMonths[monthsIndex];
                monthsIndex += 1;
            }
            Console.WriteLine($"Дата: {dayNum} {monthNames[monthsIndex]}\n");
        }
        //Домашняя работа
        Console.WriteLine("\tДомашняя работа\t");
        Console.Write("Введите год: ");
        if ((int.TryParse(Console.ReadLine(), out int year) == false) || year < 1)
        {
            Console.WriteLine("Ошибка: некорректный год");
            return;
        }
        bool isLeap = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        int daysInYear = isLeap ? 366 : 365;
        int febDays = isLeap ? 29 : 28;
        Console.Write($"Введите номер дня в году (1-{daysInYear}): ");
        if ((int.TryParse(Console.ReadLine(), out int dayNum2)) == false || dayNum2 < 1 || dayNum2 > daysInYear)
        {
            Console.WriteLine($"Ошибка: день должен быть от 1 до {daysInYear}");
            return;
        }
        int[] daysInMonths2 = { 31, febDays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] monthNames2 = { "января", "февраля", "марта", "апреля", "мая", "июня", "июля", "августа", "сентября", "октября", "ноября", "декабря" };
        int monthIndex2 = 0;
        while (dayNum2 > daysInMonths2[monthIndex2])
        {
            dayNum2 -= daysInMonths2[monthIndex2];
            monthIndex2 += 1;
        }
        Console.WriteLine($"Результат: {dayNum2} {monthNames2[monthIndex2]}");
    }
}


