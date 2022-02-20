Console.WriteLine("Привет!!Удачи тебе))");
while (true)
{
    Console.WriteLine("Что рассчитать, периметр или площадь (p или s):");
    string formula = Console.ReadLine();

    Console.WriteLine("Введите длину стороны прямоуголника - а");
    float a = float.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину стороны прямоуголника - b");
    float b = float.Parse(Console.ReadLine());

    if (formula == "p")
    {
        float p = (a + b) * 2;
        Console.WriteLine($"Периметр прямоуголника равен: {p}");
    }
    if (formula == "s")
    {
        float s = a * b;
        Console.WriteLine($"Площадь прямоуголника равна: {s}");
    }
    Console.WriteLine("Все работает! Я молодец!");
}