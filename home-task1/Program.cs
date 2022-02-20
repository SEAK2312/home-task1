while (true)
{
    Console.WriteLine("Привет! Это ветка Мирона");
    Console.WriteLine("Введите длину стороны прямоуголника - а");
    float a = float.Parse(Console.ReadLine());

    Console.WriteLine("Введите длину стороны прямоуголника - b");
    float b = float.Parse(Console.ReadLine());

    float p = (a + b) * 2;
    Console.WriteLine($"Периметр прямоуголника равен: {p}");

    float s = a * b;
    Console.WriteLine($"Площадь прямоуголника равна: {s}");
    Console.WriteLine("Все работает! Я молодец!");
}