int command = 0;
while (command != 9)
{
    Console.WriteLine("Введите номер команды из предложенных ниже: ");
    Console.WriteLine("1. Сложить 2 числа");
    Console.WriteLine("2. Вычесть первое число из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1% от числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    command = Convert.ToInt32(Console.ReadLine());

    if (command == 1)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = a + b;

        Console.WriteLine(a + " + " + b + " = " + c);

    }
    if (command == 2)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = b - a;

        Console.WriteLine(a + " - " + b + " = " + c);
    }
    if (command == 3)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = a * b;

        Console.WriteLine(a + " * " + b + " = " + c);

    }
    if (command == 4)
    {
        Console.WriteLine("Введите первое число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите второе число:");
        int b = Convert.ToInt32(Console.ReadLine());

        int c = a / b;

        Console.WriteLine(a + " / " + b + " = " + c);
    }
    if (command == 5)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        int c = 1;

        Console.WriteLine("Введите степень:");
        int b = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < b; i++)
        {
            c = c * a;
        }

        Console.WriteLine(a + " ^ " + b + " = " + c);
    }
    if (command == 6)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Корень " + a + " = " + Math.Sqrt(a));

    }
    if (command == 7)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());
        double b;
        b = 0.01;

        Console.WriteLine("Один процент от числа " + a + " = " + a * b);

    }
    if (command == 8)
    {
        Console.WriteLine("Введите число:");
        int a = Convert.ToInt32(Console.ReadLine());

        int b = 1;
        int c = 1;

        for (int d = 0; d < a; d++)
        {
            c = c * b;
            b++;
        }

        Console.WriteLine("Ответ:");
        Console.WriteLine(c);

    }
}