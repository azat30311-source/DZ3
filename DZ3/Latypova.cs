namespace DZ3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ЗАДАЧА 1
            Console.WriteLine("\tЗадача 1\t");
            Console.WriteLine("Введите 10 чисел по одному");
            int[] numbers = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Ошибка ввода. Введите целое число: ");
                }
            }
            int violationOrdinal = -1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    violationOrdinal = i + 1;
                    break;
                }
            }
            if (violationOrdinal == -1)
            {
                Console.WriteLine("Последовательность упорядочена по возрастанию\n");
            }
            else
            {
                Console.WriteLine($"Последовательность нарушена, порядковый номер первого нарушающего числа: {violationOrdinal}\n");
            }
            //ЗАДАЧА 2
            Console.WriteLine("\tЗадача 2\t");
            Console.WriteLine("Введите номер карты k (6 <= k <= 14)");
            Console.Write("Ввод: ");
            try
            {
                int k = int.Parse(Console.ReadLine());

                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException("Номер карты должен быть от 6 до 14");
                }
                string cardName = k switch
                {
                    6 => "Шестерка",
                    7 => "Семерка",
                    8 => "Восьмерка",
                    9 => "Девятка",
                    10 => "Десятка",
                    11 => "Валет",
                    12 => "Дама",
                    13 => "Король",
                    14 => "Туз",
                    _ => "Неизвестно"
                };
                Console.WriteLine($"Результат: Достоинство карты — {cardName}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка, вы ввели не число");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"Ошибка: {ex.ParamName}");
            }
            finally
            {
                Console.WriteLine("Завершение работы алгоритма определения карты.\n");
            }
            //ЗАДАЧА 3
            Console.WriteLine("\tЗадача 3\t");
            Console.WriteLine("Введите профессию (например, 'Jabroni' или 'Programmer')");
            Console.Write("Ввод: ");
            string input = Console.ReadLine()?.Trim().ToLower() ?? "";
            string drink = input switch
            {
                "jabroni" => "Patron Tequila",
                "school counselor" => "Anything with Alcohol",
                "programmer" => "Hipster Craft Beer",
                "bike gang member" => "Moonshine",
                "politician" => "Your tax dollars",
                "rapper" => "Cristal",
                _ => "Beer"
            };
            Console.WriteLine($"Результат: {drink}\n");
            //ЗАДАЧА 4
            Console.WriteLine("\tЗадача 4\t");
            Console.WriteLine("Введите номер дня недели (1-7).");
            Console.Write("Ввод: ");
            if (int.TryParse(Console.ReadLine(), out int dayNum) && dayNum >= 1 && dayNum <= 7)
            {
                DaysOfWeek day = (DaysOfWeek)dayNum;
                Console.WriteLine($"Результат: День недели — {day}\n");
            }
            else
            {
                Console.WriteLine("Ошибка: Некорректный номер дня недели.\n");
            }
            //ЗАДАЧА 5
            Console.WriteLine("\tЗадача 5\t");
            string[] bag = { "Teddy Bear", "Hello Kitty", "Car", "Barbie doll", "Robot", "Hello Kitty", "Lego" };
            Console.WriteLine("Содержимое массива: " + string.Join(", ", bag));
            int dollCount = 0;
            foreach (string item in bag)
            {
                if (item == "Hello Kitty" || item == "Barbie doll")
                {
                    dollCount++;
                }
            }
            Console.WriteLine($"Результат: Количество кукол в сумке = {dollCount}\n");
            Console.ReadKey();
        }
    }
}
