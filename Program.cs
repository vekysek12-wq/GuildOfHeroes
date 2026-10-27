Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);

yaroslav.Heal = 75;

Console.WriteLine(">>> Герой 1 <<<");
Console.WriteLine($"Имя: {yaroslav.Name}");
Console.WriteLine($"Здоровье: {yaroslav.Heal}");
Console.WriteLine($"Уровень: {yaroslav.Lvl}");
Console.WriteLine($"Опыт: {yaroslav.Exp}");

Console.WriteLine();

Console.WriteLine(">>> Герой 2 <<<");
Console.WriteLine($"Имя: {anastasia.Name}");
Console.WriteLine($"Здоровье: {anastasia.Heal}");
Console.WriteLine($"Уровень: {anastasia.Lvl}");
Console.WriteLine($"Опыт: {anastasia.Exp}");

Console.WriteLine();

Console.WriteLine(">>> Герой 3 <<<");
Console.WriteLine($"Имя: {artem.Name}");
Console.WriteLine($"Здоровье: {artem.Heal}");
Console.WriteLine($"Уровень: {artem.Lvl}");
Console.WriteLine($"Опыт: {artem.Exp}");